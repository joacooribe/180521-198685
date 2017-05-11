namespace Domain
{
    public interface AdministratorPersistenceProvider
    {
        void AddAdministrator(Administrator administrator);
        Administrator GetAdministratorFromColecction(Administrator administratorToFind);
        void LoginAdministrator(string emial, string password);
    }
}
