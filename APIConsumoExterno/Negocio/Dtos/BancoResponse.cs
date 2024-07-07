using System.Text.Json.Serialization;

namespace APIConsumoExterno.Negocio.Dtos
{
    public class BancoResponse
    {
        [JsonPropertyName("Codigo")]
        public string? ispb { get; set; }
        [JsonPropertyName("Abreviatura")]
        public string? name { get; set; }
        [JsonPropertyName("CodigoBanco")]
        public string? code { get; set; }
        [JsonPropertyName("NomeCompleto")]
        public string? fullName { get; set; }

    }
}