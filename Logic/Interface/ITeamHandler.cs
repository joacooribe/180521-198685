﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Logic
{
    public interface ITeamHandler
    {
        void AddTeam(Team team);
        Team GetTeamFromCollection(string nameOfTeam);
        void ModifyTeamMaxUsers(string nameOfTeam, int newMax);
        void ModifyTeamDescription(string nameOfTeam, string newDescription);
        void DeleteTeam(Team team);
        List<User> GetUsersFromTeam(Team team);
        void RemoveUser(Team team,User user);
        bool ExistsTeam(Team team);
        void ModifyTeamUsers(Team team, ICollection<User> users);
        List<Team> LoadTeams();
    }
}
