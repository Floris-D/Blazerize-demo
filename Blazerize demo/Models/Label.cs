using System.ComponentModel.DataAnnotations.Schema;

namespace Blazerize_demo.Models
{
    [Table("Label")]
    public class Label
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Wagen))]
        public required int WagenKey { get; set; }
        public Wagen? Wagen { get; set; }
        public bool isActive { get; set; }
        public string? Name { get; set; }
    }
}
