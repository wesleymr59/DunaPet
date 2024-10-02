using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DunaPet.App.Entities.MySQL
{
    [Table("Pet")]
    public class Pets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // AUTO_INCREMENT
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? LastName { get; set; } // Nullable, pois tem DEFAULT NULL

        [Required]
        public int UserId { get; set; } // FK para a tabela `Users`

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? Picture { get; set; } // Nullable, pois tem DEFAULT NULL

        public DateTime? Birthdate { get; set; } // Nullable, pois tem DEFAULT NULL

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? Weigth { get; set; } // Nullable, pois tem DEFAULT NULL

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? Race { get; set; } // Nullable, pois tem DEFAULT NULL

        [MaxLength(100)] // Limite conforme a definição do varchar(100)
        public string? Type { get; set; } // Nullable, pois tem DEFAULT NULL

        // Propriedade de navegação para a FK
        [ForeignKey("UserId")]
        public virtual User User { get; set; } // Referência à classe User

        // Construtor padrão
        public Pets() { }

        // Construtor com parâmetros
        public Pets(string name, int userId, string? lastName = null, string? picture = null, DateTime? birthdate = null, string? weigth = null, string? race = null, string? type = null)
        {
            Name = name;
            UserId = userId;
            LastName = lastName;
            Picture = picture;
            Birthdate = birthdate;
            Weigth = weigth;
            Race = race;
            Type = type;
        }
    }
}
