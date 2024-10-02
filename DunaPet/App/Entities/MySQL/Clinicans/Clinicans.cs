using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.MySQL
{
    [Table("Clinicans")]
    public class Clinican
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTO_INCREMENT para o campo Id
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)] // Campos opcionais com varchar(100)
        public string? City { get; set; }

        [MaxLength(100)]
        public string? PostalCode { get; set; }

        [MaxLength(100)]
        public string? State { get; set; }

        [MaxLength(100)]
        public string? Country { get; set; }

        [Required]
        public int OpeningHoursId { get; set; } // FK para a tabela `ClinicOperatingHours`

        [Required]
        public bool Active { get; set; }

        // Propriedade de navegação para a FK com ClinicOperatingHours
        [ForeignKey("OpeningHoursId")]
        public virtual ClinicOperatingHour ClinicOperatingHour { get; set; }
        // Construtor padrão (necessário para o Entity Framework)
        public Clinican() { }

        // Construtor completo
        public Clinican(string name, int openingHoursId, bool active = true, string? city = null, string? postalCode = null, string? state = null, string? country = null)
        {
            Name = name;
            City = city;
            PostalCode = postalCode;
            State = state;
            Country = country;
            OpeningHoursId = openingHoursId;
            Active = active;
        }
    }
}

