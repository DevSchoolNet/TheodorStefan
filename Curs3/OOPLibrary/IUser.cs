namespace OOPLibrary
{
    public interface IUser
    {
        string Email { get; set; }
        string UserName { get; }

        void Login(string Name, string Password);
        void Logout();
    }
}