namespace Domain
{
    public interface ColaboratorPersistenceProvider : UserPersistenceProvider
    {
        void AddColaborator(Colaborator colaborator);
        new User GetUserFromColecction(string mailOfColaborator);
        void LoginColaborator(string mail, string password);
    }
}
