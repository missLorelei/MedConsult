using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedConsult.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            //var appSettingsPath = args.Length != 0 && !string.IsNullOrWhiteSpace(args[0])
            //    ? args[0]
            //    : Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "BrainBoard.Web");

            //Console.WriteLine(appSettingsPath);

            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(appSettingsPath)
            //    .AddJsonFile("appsettings.json")
            //    .Build();
            //var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //var connectionString = configuration.GetConnectionString("DefaultConnection");

            //builder.UseSqlServer(connectionString);
            //return new ApplicationDbContext(builder.Options);
            return null;
        }
    }
}
