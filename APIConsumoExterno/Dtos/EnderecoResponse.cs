
using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Dtos
{
    public class EnderecoResponse
    {
        [JsonPropertyName("CEP")]
        public string? CEP { get; set; }
        [JsonPropertyName("Estado")]
        public string? state { get; set; }
        [JsonPropertyName("Cidade")]
        public string? city { get; set; }
        [JsonPropertyName("Regiao")]
        public string? neighborhood { get; set; }

        [JsonPropertyName("Rua")]
        public string? street { get; set; }
        [JsonIgnore]
        public string? service { get; set; }
       
      
    }
}