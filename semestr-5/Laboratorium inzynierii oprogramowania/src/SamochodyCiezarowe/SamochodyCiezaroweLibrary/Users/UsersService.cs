using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SamochodyCiezaroweLibrary.Persistence;

namespace SamochodyCiezaroweLibrary.Users
{
    public class UsersService
    {
        private static readonly Random Random = new();

        private readonly IPersistentStorage<List<User>> _persistence = new PersistentStorage<List<User>>();

        private readonly string filename = "users.json";

        public UsersService(IList<UserProxy> users)
        {
            Users = users;
            AssertFirstUser();
        }

        public IList<UserProxy> Users { get; }

        private List<User> users => Users.Select(u => u.User).ToList();

        public UserProxy FindUser(string name)
        {
            return Users.FirstOrDefault(user => user.Name == name);
        }

        private T CreateUser<T>(string username, string password) where T : User, new()
        {
            if (FindUser(username) != null) throw new Exception($"Użytkownik o nazwie {username} już istnieje.");
            if (string.IsNullOrEmpty(password)) throw new Exception("Hasło nie może być puste.");
            T user = new()
            {
                Id = Users.Count == 0 ? 1 : Users.Select(u => u.Id).Max() + 1,
                Name = username
            };
            UserProxy userProxy = new() { User = user };
            userProxy = SetPassword(userProxy, password);
            Users.Add(userProxy);
            return user;
        }

        private static UserProxy SetPassword(UserProxy user, string password)
        {
            string salt = GenerateSalt();
            string hash = GetHash(salt + password);
            user.User.Salt = salt;
            user.User.Hash = hash;
            return user;
        }

        public Operator CreateOperator(string username, string password)
        {
            return CreateUser<Operator>(username, password);
        }

        public Administrator CreateAdministrator(string username, string password)
        {
            return CreateUser<Administrator>(username, password);
        }

        public UserProxy Authorize(string username, string password)
        {
            UserProxy user = FindUser(username);
            if (user == null) throw new Exception($"Nie znaleziono użytkownika: {username}");
            if (Verify(password, user.Salt, user.Hash)) return user;
            throw new Exception("Niepoprawne hasło.");
        }

        private static string GetHash(string input)
        {
            using SHA256 sha256Hash = SHA256.Create();
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new();
            for (int i = 0; i < data.Length; i++) sBuilder.Append(data[i].ToString("x2"));
            return sBuilder.ToString();
        }

        private static bool Verify(string password, string salt, string hash)
        {
            string hashOfInput = GetHash(salt + password);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        private static string GenerateSalt(int length = 4)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return string.Join("", Enumerable.Range(0, length).Select(x => chars[Random.Next(chars.Length)]));
        }

        public void ChangePassword(string username, string password)
        {
            UserProxy user = FindUser(username);
            string salt = GenerateSalt();
            user.User.Salt = salt;
            user.User.Hash = GetHash(salt + password);
        }

        public void DeleteUser(string username)
        {
            UserProxy user = FindUser(username);
            Users.Remove(user);
        }

        public void Save()
        {
            using FileStream file = File.Open(filename, FileMode.Create, FileAccess.Write);
            using StreamWriter writer = new(file);
            _persistence.Save(users, writer);
            writer.Close();
            file.Close();
        }

        public void Load()
        {
            using FileStream file = File.Open(filename, FileMode.Open, FileAccess.Read);
            using StreamReader reader = new(file);
            List<User> _users = _persistence.Load(reader);
            Users.Clear();
            foreach (User user in _users) Users.Add(new UserProxy { User = user });
            AssertFirstUser();
        }

        private void AssertFirstUser()
        {
            if (FindUser("admin") == null) CreateAdministrator("admin", "admin1");
        }
    }
}