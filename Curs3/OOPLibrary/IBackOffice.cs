namespace OOPLibrary
{
    public interface IBackOffice
    {
        bool ApproveCredit(string CNP);
        void SendNotifications(string CNP);
    }
}