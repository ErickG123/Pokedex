using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        [Key]
        public uint Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [StringLength(25)]
        public string Cor { get; set; }

        public List<PokemonTipo> Pokemons { get; set; }
    }
}
