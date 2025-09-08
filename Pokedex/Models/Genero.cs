using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        public uint Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
    }
}