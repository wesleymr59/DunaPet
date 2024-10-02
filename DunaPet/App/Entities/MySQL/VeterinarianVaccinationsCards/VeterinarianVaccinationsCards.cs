
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DunaPet.App.Entities.MySQL
{
    [Table("VeterinarianVaccinationsCards")]
    public class VeterinarianVaccinationCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTO_INCREMENT
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string NameMedication { get; set; } = string.Empty; // Nome da medicação

        [Required]
        public int PetId { get; set; } // FK para a tabela `Pet`

        [Required]
        public int VeterinarianId { get; set; } // FK para a tabela `Veterinarians`

        [Required]
        public int MedicalConsultationId { get; set; } // FK para a tabela `Medical Consultations`

        [Required]
        public DateTime DateMedication { get; set; } = DateTime.UtcNow; // Data da medicação

        public DateTime? RemenberMedication { get; set; } // Data de lembrete, pode ser nulo

        // Propriedades de navegação
        [ForeignKey("PetId")]
        public virtual Pets Pets { get; set; } = null!; // Relacionamento com Pet

        [ForeignKey("VeterinarianId")]
        public virtual Veterinarian Veterinarian { get; set; } = null!; // Relacionamento com Veterinarians

        [ForeignKey("MedicalConsultationId")]
        public virtual MedicalConsultation MedicalConsultation { get; set; } = null!; // Relacionamento com MedicalConsultation

        // Construtor padrão
        public VeterinarianVaccinationCard() { }

        // Construtor com parâmetros
        public VeterinarianVaccinationCard(string nameMedication, int petId, int veterinarianId, int medicalConsultationId, DateTime? remenberMedication = null)
        {
            NameMedication = nameMedication;
            PetId = petId;
            VeterinarianId = veterinarianId;
            MedicalConsultationId = medicalConsultationId;
            RemenberMedication = remenberMedication;
        }
    }
}
