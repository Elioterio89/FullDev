using System.ComponentModel.DataAnnotations.Schema;

namespace EstudoFull.Models
{
    [Table("Pessoa")]
    public class Pessoa : Base
    {
        
        [Column("PrimeiroNome")]
        public string PrimeiroNome { get; set; }

        [Column("Sobrenome")]
        public string Sobrenome { get; set; }

        [Column("Endereco")]
        public string Endereco { get; set; }

        [Column("Genero")]
        public string Genero { get; set;}

    }
}
