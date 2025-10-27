using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pokedex.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public uint Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Por favor, informe")]
        public string Nome { get;  set;}
    }
}