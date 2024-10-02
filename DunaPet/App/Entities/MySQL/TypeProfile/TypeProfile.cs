using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DunaPet.App.Entities.MySQL
{
    [Table("TypeProfile")]
    public class TypeProfile
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Profile { get; set; }

        // Construtor padrão
        public TypeProfile() { }

        // Construtor personalizado
        public TypeProfile(string profile)
        {
            Profile = profile;
        }
    }
}
