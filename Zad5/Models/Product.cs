using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zad5.Models
{
    public class Product
    {
        public string Id { get; set; }
        [MaxLength(50)]
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        [MaxLength(150)]
        public string Image { get; set; }
        [MaxLength(150)]
        public string Url { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
