using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DunaPet.App.Entities.MySQL
{
    
    [Table("Medical Consulation")]
    public class MedicalConsultation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTO_INCREMENT
        public int Id { get; set; }

        [Required]
        public int PetId { get; set; } // FK para a tabela `Pet`

        public int? UserId { get; set; } // FK para a tabela `Users`, pode ser nulo

        [Required]
        public int VeterinarianId { get; set; } // FK para a tabela `Veterinarians`

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? TypeConsultation { get; set; } // tipo de consulta, pode ser nulo

        [Required]
        public string ClinicalId { get; set; } = string.Empty; // FK para `Clinicals`

        // Propriedades de navegação
        [ForeignKey("PetId")]
        public virtual Pets Pets { get; set; } = null!; // Relacionamento com Pet

        [ForeignKey("UserId")]
        public virtual User? User { get; set; } // Relacionamento com Users

        [ForeignKey("VeterinarianId")]
        public virtual Veterinarian Veterinarian { get; set; } = null!; // Relacionamento com Veterinarians

        // Construtor padrão
        public MedicalConsultation() { }

        // Construtor com parâmetros
        public MedicalConsultation(int petId, int? userId, int veterinarianId, string typeConsultation, string clinicalId)
        {
            PetId = petId;
            UserId = userId;
            VeterinarianId = veterinarianId;
            TypeConsultation = typeConsultation;
            ClinicalId = clinicalId;
        }
    }
}

