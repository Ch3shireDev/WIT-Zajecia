using System;
using SamochodyCiezaroweLibrary.Users;

namespace SamochodyCiezaroweAppWpf.Users
{
    public class UserEditorModel
    {
        public UserEditorModel(UserEditorMode mode, UserProxy userProxy)
        {
            Mode = mode;
            if (userProxy == null) return;
            Username = userProxy.Name;
        }

        public UserEditorMode Mode { get; }
        public string Username { get; set; }

        public void Save(string passwordA, string passwordB)
        {
            if (string.IsNullOrEmpty(passwordA)) throw new Exception("Hasło nie może być puste!");
            if (passwordA != passwordB) throw new Exception("Podane hasła muszą być identyczne.");
            if (string.IsNullOrWhiteSpace(Username)) throw new Exception("Nazwa użytkownika nie może być pusta.");
            switch (Mode)
            {
                case UserEditorMode.CreateOperator:
                    UsersSingleton.Instance.Service.CreateOperator(Username, passwordA);
                    break;
                case UserEditorMode.CreateAdministrator:
                    UsersSingleton.Instance.Service.CreateAdministrator(Username, passwordA);
                    break;
                case UserEditorMode.Edit:
                    UsersSingleton.Instance.Service.ChangePassword(Username, passwordA);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}