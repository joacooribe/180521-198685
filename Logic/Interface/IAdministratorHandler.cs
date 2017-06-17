using Domain;
using System.Collections.Generic;

namespace Logic
{
    public interface IAdministratorHandler : IUserHandler
    {
        void AddAdministrator(Administrator administrator);
        bool ExistsAdministrator(User administrator);
        List<Team> GetTeams(User administrator);
    }
}