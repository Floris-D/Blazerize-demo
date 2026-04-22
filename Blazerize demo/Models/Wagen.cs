using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazerize_demo.Models
{
    [Table("Wagen")]
    public class Wagen
    {
        [Key]
        public int Id { get; set; }
        public required string Kenteken { get; set; } = string.Empty;
        public required string Versie { get; set; } = string.Empty;
        public  ICollection<Label>? Labels { get; set; }
        public  ICollection<Datum>? Datums { get; set; }
        [EnumDataType(typeof(Diftars))]
        public Diftars Diftar { get; set; }
        public required DateTime? CreateDatum { get; set; } 
        public required DateTime? UpdateDatum { get; set; }
    }

    public enum Diftars
    {
        Vrijgave = 0,
        Selectief = 1,
    };
}