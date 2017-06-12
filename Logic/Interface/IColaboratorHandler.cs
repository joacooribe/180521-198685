using Domain;

namespace Logic
{
    public interface IColaboratorHandler : IUserHandler
    {
        void AddColaborator(Colaborator colaborator);
        bool ExistsColaborator(Colaborator colaborator);
    }
}
