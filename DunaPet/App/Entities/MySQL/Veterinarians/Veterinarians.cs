using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.MySQL
{
    [Table("Veterinarians")]
    public class Veterinarian
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTO_INCREMENT
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; } // FK para a tabela `Users`

        [Required]
        public int ClinicalId { get; set; } // FK para a tabela `Clinicans`

        [Required]
        public bool Active { get; set; } // tinyint(1)

        // Propriedades de navegação
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!; // Relacionamento com Users

        [ForeignKey("ClinicalId")]
        public virtual Clinican Clinican { get; set; } = null!; // Relacionamento com Clinicans

        // Construtor padrão
        public Veterinarian() { }

        // Construtor com parâmetros
        public Veterinarian(int userId, int clinicalId, bool active)
        {
            UserId = userId;
            ClinicalId = clinicalId;
            Active = active;
        }
    }
}
