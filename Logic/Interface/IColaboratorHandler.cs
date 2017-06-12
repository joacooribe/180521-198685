using Domain;

namespace Logic
{
    public interface IColaboratorHandler : IUserHandler
    {
        void AddColaborator(Colaborator colaborator);
        new User GetUserFromColecction(string mailOfColaborator);
        bool ExistsColaborator(Colaborator colaborator);
    }
}
