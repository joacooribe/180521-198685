namespace Domain
{
    public interface ColaboratorPersistenceProvider
    {
        void AddColaborator(Colaborator colaborator);
        Colaborator GetColaboratorFromColecction(Colaborator colaboratorToFind);
        void LoginColaborator(string email, string password); 
    }
}
