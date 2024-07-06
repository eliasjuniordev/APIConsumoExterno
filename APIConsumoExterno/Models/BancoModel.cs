using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb;

        [JsonPropertyName("name")]
        public string? NomeAbreviado;

        [JsonPropertyName("code")]
        public int? Codigo;

        [JsonPropertyName("fullName")]
        public string? NomeCompleto;
    }
}