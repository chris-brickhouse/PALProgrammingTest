using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using PALConsoleTest.Models;

using System;

// create models class second
namespace PALConsoleTest {

    // explain what dbcontext class is
    class PALModels : DbContext {

        // these are our lists
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersAttendance> UsersAttendance { get; set; }
        public virtual DbSet<UsersGrades> UsersGrades { get; set; }

        // explain this function
        public static string GetConnectionString() {
            string applicationExeDirectory = Environment.CurrentDirectory;
            var builder = new ConfigurationBuilder()
            .SetBasePath(applicationExeDirectory)
            .AddJsonFile("appsettings.json");
            var appSettingsJson = builder.Build();
            return appSettingsJson["ConnectionStrings:Students"];
        }      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }
}
