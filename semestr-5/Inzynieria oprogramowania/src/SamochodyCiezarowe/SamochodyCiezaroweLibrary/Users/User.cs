namespace SamochodyCiezaroweLibrary.Users
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public abstract string Description { get; }
    }
}