using CPKMD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CPKMD.Data
{
    public class CPKMEDContext : DbContext
    {
        public DbSet<TrainingForm> TrainingForms { get; set; }
        public DbSet<ProgramName> ProgramNames { get; set; }
        public DbSet<EducationalProgram> EducationalPrograms { get; set; }
        public DbSet<User> Users  { get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
                if (!File.Exists(configPath))
                {
                    throw new FileNotFoundException("Файл appsettings.json не найден по пути: " + configPath);
                }

                var builder = new ConfigurationBuilder()
                    .AddJsonFile(configPath, optional: false, reloadOnChange: true);
                var configuration = builder.Build();
                var connectionString = configuration.GetConnectionString("CPKMEDConnection");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("Не удалось загрузить строку подключения из appsettings.json.");
                }

                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrainingForm>()
                .HasIndex(tf => tf.Name)
                .IsUnique();

            modelBuilder.Entity<ProgramName>()
                .HasIndex(pn => pn.Name)
                .IsUnique();

            modelBuilder.Entity<EducationalProgram>()
                .HasOne(ep => ep.ProgramName)
                .WithMany(pn => pn.EducationalPrograms)
                .HasForeignKey(ep => ep.ProgramNameId);

            modelBuilder.Entity<EducationalProgram>()
                .HasOne(ep => ep.TrainingForm)
                .WithMany(tf => tf.EducationalPrograms)
                .HasForeignKey(ep => ep.TrainingFormId);
        }
    }
}
