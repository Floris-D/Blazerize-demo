using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazerize_demo.Models
{
    [Table("Datum")]
    public class Datum
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Wagen))]
        public required int WagenKey { get; set; }
        public Wagen? Wagen { get; set; }
        public required DateTime Date { get; set; } = DateTime.Today;
        public required int TotaalKg { get; set; } = 0;
        public DateTime? CreateDatum { get; set; }
        public DateTime? UpdateDatum { get; set; }
    }

   
}
