using System;
using System.Collections.ObjectModel;
using SamochodyCiezaroweLibrary.Users;

namespace SamochodyCiezaroweAppWpf.Users
{
    public class UsersModel
    {
        public ObservableCollection<UserProxy> Users => UsersSingleton.Instance.Users;
        public UserProxy SelectedUser { get; set; }

        public void DeleteUser()
        {
            if (SelectedUser == null) throw new Exception("Należy wybrać użytkownika do usunięcia!");
            new UsersService(Users).DeleteUser(SelectedUser.Name);
        }

        public void Save()
        {
            new UsersService(Users).Save();
        }
    }
}