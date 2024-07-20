using EstudoFull.Hypermedia;
using EstudoFull.Hypermedia.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EstudoFull.Data.Dto
{
    public class LivroDto : ISupportsHyperMedia
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("genero")]
        public string Genero { get; set; }

        [JsonPropertyName("editora")]
        public string Editora { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
