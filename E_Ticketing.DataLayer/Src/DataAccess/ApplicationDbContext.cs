using E_Ticketing.CoreLayer.Entity;
using E_Ticketing.DataLayer.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.DataLayer.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public class OptionBuild
        {

            public OptionBuild()
            {
                Settings = new AppConfiguration();
                OptionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                OptionBuilder.UseMySql(Settings.MysqlConnectionString, Settings.ServerVersion);
                DBOptions = OptionBuilder.Options;
            }
            public DbContextOptionsBuilder<ApplicationDbContext> OptionBuilder { get; set; }
            public DbContextOptions<ApplicationDbContext> DBOptions { get; set; }
            private AppConfiguration Settings { get; set; }
        }
        public static OptionBuild options = new();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new VehicleCategoryMapping());
            modelBuilder.ApplyConfiguration(new VehicleMapping());



        }
        public DbSet<VehicleCategory> vehicle_categories { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }

    }
}
