using System.Text.Json.Serialization;

namespace APIConsumoExterno.Negocio.Model.Models
{
    public class BancoModel
    {
        public string? ispb { get; set; }
        public string? name { get; set; }
        public int? code { get; set; }
        public string? fullName { get; set; }
    }
}