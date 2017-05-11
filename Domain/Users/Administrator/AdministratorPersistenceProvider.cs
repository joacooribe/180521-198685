namespace Domain
{
    public interface AdministratorPersistenceProvider
    {
        void AddAdministrator(Administrator administrator);
        Administrator GetAdministratorFromColecction(string mailOfAdministratorToFind);
        void LoginAdministrator(string emial, string password);
    }
}
