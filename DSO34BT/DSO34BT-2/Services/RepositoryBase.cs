namespace DSO34BT_2.Services
{
    public abstract class RepositoryBase
    {
        public const string connectionString = @"Server=localhost;Database=DSO34BT;User Id=Arafat;Password=340$Uuxwp7Mcxo7Khy;";
        public abstract void Create(string lastName, string firstName, int age, string email);
        public abstract void Delete();
        public abstract void Update();
    }
}