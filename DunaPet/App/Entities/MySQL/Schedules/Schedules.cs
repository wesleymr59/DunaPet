using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.MySQL
{
    [Table("Schedules")]
    public class Schedules
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Sem AUTO_INCREMENT
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? Description { get; set; } // Pode ser nulo

        [Required]
        public DateTime DateStart { get; set; } // Mapeando datetime

        [Required]
        public DateTime DateEnd { get; set; } // Mapeando datetime

        [Required]
        public int VeterinarianId { get; set; } // FK para a tabela `Veterinarians`

        // Propriedade de navegação para a FK
        [ForeignKey("VeterinarianId")]
        public virtual Veterinarian Veterinarian { get; set; } // Relacionamento com Veterinarian

        // Construtor padrão
        public Schedules() { }

        // Construtor com parâmetros
        public Schedules(string name, DateTime dateStart, DateTime dateEnd, int veterinarianId, string? description = null)
        {
            Name = name;
            DateStart = dateStart;
            DateEnd = dateEnd;
            VeterinarianId = veterinarianId;
            Description = description;
        }
    }
}

