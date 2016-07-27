namespace OOPLibrary
{
    public interface IFrontOffice
    {
        void AddCustomer(string name, string CNP);
        bool OpenRelation(string Name, string CNP);
    }
}