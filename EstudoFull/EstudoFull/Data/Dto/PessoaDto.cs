using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EstudoFull.Data.Dto
{
    public class PessoaDto
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("nome")]
        public string PrimeiroNome { get; set; }

        [JsonPropertyName("sobrenome")]
        public string Sobrenome { get; set; }

        [JsonPropertyName("endereco")]
        public string Endereco { get; set; }

        [JsonPropertyName("sexo")]
        public string Genero { get; set; }
    }
}
