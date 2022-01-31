namespace SamochodyCiezaroweLibrary.Users
{
    public class UserProxy
    {
        public User User { get; set; }
        public bool IsOperator => User is Operator;
        public bool IsAdministrator => User is Administrator;
        public string Name => User.Name;
        public int Id => User.Id;
        public string Salt => User.Salt;
        public string Hash => User.Hash;
        public string Description => User.Description;
    }
}