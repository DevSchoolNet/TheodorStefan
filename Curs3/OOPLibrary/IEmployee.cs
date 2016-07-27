namespace OOPLibrary
{
    public interface IEmployee
    {
        string Departament { get; set; }
        string Id { get; set; }
        int Wage { get; set; }

        void Login(string Id, string Password);
    }
}