using DunaPet.App.Entities.MySQL;
using Microsoft.EntityFrameworkCore;

namespace Pet.Infrastructure.Data.Config
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<TypeProfile> TypeProfile { get; set; }
        public DbSet<Clinican> Clinican { get; set; }
        public DbSet<ClinicOperatingHour> ClinicOperatingHour { get; set; }
        public DbSet<MedicalConsultation> MedicalConsultation { get; set; }
        public DbSet<Pets> Pets { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Veterinarian> Veterinarian { get; set; }
        public DbSet<VeterinarianVaccinationCard> VeterinarianVaccinationCard { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Remove o método OnConfiguring se você estiver configurando o DbContext em Program.cs
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseNpgsql("Host=localhost;Database=Escola;Username=wesley;Password=root");
        //     base.OnConfiguring(optionsBuilder);
        // }
    }
}
