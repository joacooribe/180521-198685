﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Logic;
using Persistence;
using Exceptions;
using System.Globalization;

namespace Interface
{
    public partial class TeamRegisterUI : Form
    {
        private Singleton instance;
        public List<User> users { get; set; }
        public List<User> usersForTeam { get; set; }
        public TeamRegisterUI()
        {
            instance = Singleton.GetInstance;
            InitializeComponent();
            users = new List<User>();
            usersForTeam = new List<User>();
            InitializeList();
            LoadUsers();   
        }

        private void LoadUsers()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUsers.Rows.Clear();
            foreach (User user in users)
            {
                var rowIndex = dataGridViewUsers.Rows.Add(user.mail, user.name, user.surname);
                dataGridViewUsers.Rows[rowIndex].Tag = user;
            }
        }
        private void InitializeList()
        {
            List<User> allUsers = new List<User>();
            using (ContextDB context = new ContextDB())
            {
                allUsers = context.Users.ToList();
            }
            foreach(User user in allUsers)
            {
                if (user.active)
                {
                    users.Add(user);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdministratorUI administratorUI = new AdministratorUI();
            administratorUI.Show();
            Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string name = txtTeamName.Text;
            string description = txtDescription.Text;
            int maxUsers = (int)nudMaxUsers.Value;
            User user = instance.session.user;
            Administrator adminCreator = (Administrator)user;
            DateTime birthdate = DateTime.Now;
            try
            {
                Team teamToAdd = new Team();
                teamToAdd.name = name;
                teamToAdd.description = description;
                teamToAdd.maxUsers = maxUsers;
                teamToAdd.creator = adminCreator;
                teamToAdd.creationDate = birthdate;
                teamToAdd.usersInTeam = usersForTeam;
                instance.teamHandler.AddTeam(teamToAdd);
                AdministratorUI administratorUI = new AdministratorUI();
                administratorUI.Show();
                Hide();
            }
            catch (TeamException ex)
            {
                String msgError = ex.Message;
                MessageBox.Show(msgError, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void brnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridViewUsers.CurrentCell.RowIndex;
                var selectedUser = dataGridViewUsers.Rows[selectedRow].Tag;
                usersForTeam.Add((User)selectedUser);
                users.Remove((User)selectedUser);
                LoadUsers();
                ReloadUsersForTeam();
            }
            catch(Exception)
            {
                MessageBox.Show("No hay mas usuarios para agregar a la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ReloadUsersForTeam()
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            this.dataGridViewUserForTeam.Rows.Clear();
            foreach (User user in usersForTeam)
            {
                var rowIndex = dataGridViewUserForTeam.Rows.Add(user.mail, user.name, user.surname);
                dataGridViewUserForTeam.Rows[rowIndex].Tag = user;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridViewUserForTeam.CurrentCell.RowIndex;
                var selectedUser = dataGridViewUserForTeam.Rows[selectedRow].Tag;
                usersForTeam.Remove((User)selectedUser);
                users.Add((User)selectedUser);
                LoadUsers();
                ReloadUsersForTeam();
            }
            catch (Exception)
            {
                MessageBox.Show("No puede quitar mas usuarios del equipo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
