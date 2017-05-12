namespace Domain
{
    public interface AdministratorPersistenceProvider
    {
        void AddAdministrator(Administrator administrator);
        Administrator GetAdministratorFromColecction(string mailOfAdministrator);
        void LoginAdministrator(string mail, string password);
    }
}
