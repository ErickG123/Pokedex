using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Models
{
    [Table("Pokemon")]
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint Numero { get; set; }

        public string Nome { get; set; }

        [Required(ErrorMessage = "A região é obrigatória.")]
        public uint RegiaoId { get; set; }
        [ForeignKey("RegiaoId")]
        public Regiao Regiao { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public uint GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [Column(TypeName = "double(5, 2)")]
        [Required(ErrorMessage = "A altura é obrigatória.")]
        public double Altura { get; set; } = 0;

        [Column(TypeName = "double(7, 3)")]
        [Required(ErrorMessage = "O peso é obrigatório.")]
        public double Peso { get; set; } = 0;

        [StringLength(200)]
        public string Imagem { get; set; }

        [StringLength(400)]
        public string Animacao { get; set; }

        public List<PokemonTipo> Tipos { get; set; }
    }
}
