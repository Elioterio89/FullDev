using System.ComponentModel.DataAnnotations.Schema;

namespace EstudoFull.Models
{
    public class Base
    {
        [Column("Id")]
        public long Id { get; set; }
    }
}
