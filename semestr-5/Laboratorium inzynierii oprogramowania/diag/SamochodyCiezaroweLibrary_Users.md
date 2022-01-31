```mermaid
classDiagram
User <|-- Administrator
User <|-- Operator

class Administrator {
    +string Description => "Administrator";
}

class Operator {
    +string Description => "Operator systemu";
}

class User {
    <<abstract>>
    + int Id;
    + string Name;
    + string Salt;
    + string Hash ;
    + abstract string Description;
}

class UserProxy {
    + User User 
    + bool IsOperator => User is Operator;
    + bool IsAdministrator => User is Administrator;
    + string Name => User.Name;
    + int Id => User.Id;
    + string Salt => User.Salt;
    + string Hash => User.Hash;
    + string Description => User.Description;
}

class UsersService {
    - static readonly Random Random = new();
    - IPersistentStorage<List<User>> _persistence = new PersistentStorage<List<User>>();
    - string filename = "users.json";
    + UsersService(IList<UserProxy> users);
    + IList<UserProxy> Users;
    - List<User> users => Users.Select(u => u.User).ToList();
    + UserProxy FindUser(string name);
    - T CreateUser<T>(string username, string password);
    - static UserProxy SetPassword(UserProxy user, string password);
    + Operator CreateOperator(string username, string password);
    + Administrator CreateAdministrator(string username, string password);
    + UserProxy Authorize(string username, string password);
    - static string GetHash(string input);
    - static bool Verify(string password, string salt, string hash);
    - static string GenerateSalt(int length = 4);
    + void ChangePassword(string username, string password);
    + void DeleteUser(string username);
    + void Save();
    + void Load();
    - void AssertFirstUser();
}
