using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsDb
{
    public class KyrsachContext : DbContext
    {
        string currentConnectionString;
        public DbSet<DatabaseUser> DbUsers { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Address> Adresses { get; set; }
        public DbSet<InstalledCamera> PlacedCameras { get; set; }
        public DbSet<CameraOwner> CameraOwners { get; set; }
        public KyrsachContext(DbContextOptions<KyrsachContext> options, string connString = "")
            : base(options)
        {
            if (connString == "")
            {
                currentConnectionString = StaticHelpers.baseConnectionString;
            }
            else
            {
                currentConnectionString = connString;
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(currentConnectionString);
            //@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }
        public static void EnsureCreatingMissingTables<TDbContext>(TDbContext dbContext) where TDbContext : DbContext
        {
            var type = typeof(TDbContext);
            var dbSetType = typeof(DbSet<>);

            var dbPropertyNames = type.GetProperties().Where(p => p.PropertyType.Name == dbSetType.Name)
                .Select(p => p.Name).ToArray();

            foreach (var entityName in dbPropertyNames)
            {
                CheckTableExistsAndCreateIfMissing(dbContext, entityName);
            }
        }

        private static void CheckTableExistsAndCreateIfMissing(DbContext dbContext, string entityName)
        {
            var defaultSchema = dbContext.Model.GetDefaultSchema();
            var tableName = string.IsNullOrWhiteSpace(defaultSchema) ? $"[{entityName}]" : $"[{defaultSchema}].[{entityName}]";

            try
            {
                _ = dbContext.Database.ExecuteSqlRaw($"SELECT TOP(1) * FROM {tableName}"); //Throws on missing table
            }
            catch (Exception)
            {
                var scriptStart = $"CREATE TABLE {tableName}";
                const string scriptEnd = "GO";
                var script = dbContext.Database.GenerateCreateScript();

                var tableScript = script.Split(scriptStart).Last().Split(scriptEnd);
                var first = $"{scriptStart} {tableScript.First()}";

                dbContext.Database.ExecuteSqlRaw(first);
                //Log.Information($"Database table: '{tableName}' was created.");
            }
        }
    }

}
