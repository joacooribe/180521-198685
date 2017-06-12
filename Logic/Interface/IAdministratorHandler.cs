using Domain;

namespace Logic
{
    public interface IAdministratorHandler : IUserHandler
    {
        void AddAdministrator(Administrator administrator);
        new User GetUserFromColecction(string mailOfAdministrator);
        bool ExistsAdministrator(Administrator administrator);
    }
}