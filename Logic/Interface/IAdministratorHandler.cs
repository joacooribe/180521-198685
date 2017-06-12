using Domain;

namespace Logic
{
    public interface IAdministratorHandler : IUserHandler
    {
        void AddAdministrator(Administrator administrator);
        bool ExistsAdministrator(Administrator administrator);
    }
}