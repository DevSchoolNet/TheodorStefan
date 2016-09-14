using System.Security.Cryptography.X509Certificates;

namespace OOPLibrary
{
    public interface IUser
    {
        string Email { get; set; }
        string UserName { get; }
        string Password { get; }

        void Login(string Name, string Password);
        void Logout();
    }
}