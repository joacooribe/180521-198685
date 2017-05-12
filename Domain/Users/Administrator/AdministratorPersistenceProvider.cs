namespace Domain
{
    public interface AdministratorPersistenceProvider : UserPersistenceProvider
    {
        void AddAdministrator(Administrator administrator);
        new User GetUserFromColecction(string mailOfAdministrator);
        void LoginAdministrator(string mail, string password);
    }
}
