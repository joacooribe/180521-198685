namespace Domain
{
    public interface ColaboratorPersistenceProvider
    {
        void AddColaborator(Colaborator colaborator);
        Colaborator GetColaboratorFromList(Colaborator colaborator);
    }
}
