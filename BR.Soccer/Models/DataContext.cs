﻿using System.Data.Entity;

namespace BR.Soccer.Models
{
    public class DataContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<BR.Soccer.Models.DataContext>());

        public DataContext() : base("name=DataContext")
        {
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Group> Groups { get; set; }


        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Game> Games { get; set; }
    }
}
