using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Persistence
{
   public class ContextDB : DbContext
    {
        public ContextDB() : base() { }
        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Colaborator> Colaborators { get; set; }
        public DbSet<Blackboard> Blackboards { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TextBox> TextBoxes { get; set; }
        public DbSet<Image> Images { get; set; }

        public void EmptyTable()
        {
            foreach (Blackboard board in Blackboards)
            {
                Blackboards.Remove(board);
            }
            foreach (Team team in Teams)
            {
                Teams.Remove(team);
            }
            foreach (User user in Users)
            {
                Users.Remove(user);
            }
            foreach (Administrator admin in Administrators)
            {
                Administrators.Remove(admin);
            }
            foreach (Colaborator colab in Colaborators)
            {
                Colaborators.Remove(colab);
            }
            foreach (Comment comment in Comments)
            {
                Comments.Remove(comment);
            }
            foreach (TextBox textbox in TextBoxes)
            {
                TextBoxes.Remove(textbox);
            }
            foreach (Image image in Images)
            {
                Images.Remove(image);
            }
            SaveChanges();
        }

        public void EmptyAndCreate()
        {
            EmptyTable();

            Colaborator colaborator1 = new Colaborator();
            colaborator1.name = "Colab";
            colaborator1.surname = "Orator";
            colaborator1.mail = "colab@gmail.com";
            colaborator1.password = "colaborator1";
            colaborator1.birthday = new DateTime(1992, 9, 10);
            colaborator1.teams = new List<Team>();
            Colaborators.Add(colaborator1);
            SaveChanges();

            Administrator administrator1 = new Administrator();
            administrator1.name = "Admin";
            administrator1.surname = "Istrator";
            administrator1.mail = "admin@admin.com";
            administrator1.password = "a11111";
            administrator1.birthday = new DateTime(1992, 9, 10);
            administrator1.teams = new List<Team>();
            Administrators.Add(administrator1);
            SaveChanges();

            Team team1 = new Team();
            team1.name = "Team 1";
            team1.maxUsers = 5;
            team1.description = "This is the description.";
            team1.creator = administrator1;
            team1.creationDate = DateTime.Now;
            List<User> usersInTeam = new List<User>();
            usersInTeam.Add(administrator1);
            team1.usersInTeam = usersInTeam;
            Teams.Add(team1);
            SaveChanges();

            Team team2 = new Team();
            team2.name = "Team 2";
            team2.maxUsers = 3;
            team2.description = "Description";
            team2.creator = administrator1;
            team2.creationDate = DateTime.Now;
            List<User> usersInTeam2 = new List<User>();
            usersInTeam2.Add(administrator1);
            usersInTeam2.Add(colaborator1);
            team2.usersInTeam = usersInTeam2;
            Teams.Add(team2);
            SaveChanges();

            administrator1.teams.Add(team1);
            SaveChanges();
            administrator1.teams.Add(team2);
            SaveChanges();
            colaborator1.teams.Add(team2);
            SaveChanges();
        }


        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany<Team>(u => u.teams)
                                       .WithMany(t => t.usersInTeam)
                                       .Map(ts =>
                                       {
                                           ts.MapLeftKey("User");
                                           ts.MapRightKey("Team");
                                           ts.ToTable("Teams_And_Users");
                                       });
        }

    }
}
