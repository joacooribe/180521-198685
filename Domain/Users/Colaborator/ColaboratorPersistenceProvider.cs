namespace Domain
{
    public interface ColaboratorPersistenceProvider
    {
        void AddColaborator(Colaborator colaborator);
        Colaborator GetColaboratorFromColecction(string mailOfColaborator);
        void LoginColaborator(string mail, string password);
    }
}
