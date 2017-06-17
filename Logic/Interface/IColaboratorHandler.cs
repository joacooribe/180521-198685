using Domain;
using System.Collections.Generic;

namespace Logic
{
    public interface IColaboratorHandler : IUserHandler
    {
        void AddColaborator(Colaborator colaborator);
        bool ExistsColaborator(Colaborator colaborator);
        List<Team> GetTeams(User colaborator);
    }
}
