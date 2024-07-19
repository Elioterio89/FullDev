using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstudoFull.Models
{

    [Table("Livro")]
    public class Livro : Base
    {
      
        [Column("Titulo")]
        public string Titulo { get; set; }

        [Column("Genero")]
        public string Genero { get; set; }

        [Column("Editora")]
        public string Editora { get; set; }

        [Column("Autor")]
        public string Autor { get; set; }

    }
}
