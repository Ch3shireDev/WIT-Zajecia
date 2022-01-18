using System.Collections.ObjectModel;
using SamochodyCiezaroweLibrary.Users;

namespace SamochodyCiezaroweAppWpf.Users
{
    public class UsersSingleton
    {
        public UsersSingleton()
        {
            Service = new UsersService(Users);
        }

        public static UsersSingleton Instance { get; } = new();

        public ObservableCollection<UserProxy> Users { get; } = new();
        public UsersService Service { get; }
    }
}