using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.MySQL
{
    [Table("ClinicOperatingHours")]
    public class ClinicOperatingHour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTO_INCREMENT
        public int Id { get; set; }

        [Required]
        [MaxLength(10)] // Limite conforme a definição do varchar(10)
        public string DayOfWeek { get; set; } = string.Empty;

        [Required]
        public TimeSpan OpeningTime { get; set; } // TIME no MySQL mapeado para TimeSpan no C#

        [Required]
        public TimeSpan ClosingTime { get; set; }

        [Required]
        public int ClinicalId { get; set; } // FK para a tabela `Clinicans`

        public bool IsOpen { get; set; } = true; // tinyint(1), valores booleanos (0 ou 1)

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Mapeando timestamp com valor padrão de CURRENT_TIMESTAMP

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Atualizado automaticamente

        // Propriedade de navegação para a FK
        [ForeignKey("ClinicalId")]
        public virtual Clinican Clinican { get; set; }
    }
}
