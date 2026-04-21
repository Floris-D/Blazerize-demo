using System.ComponentModel.DataAnnotations;

namespace Blazerize_demo.Models
{
    public class Wagen : Bedrijf
    {
        [Key]
        public int Id { get; set; }
        public string Kenteken { get; set; } = string.Empty;
        public string Versie { get; set; } = string.Empty;
        public IEnumerable<Label>? Labels { get; set; }
        public bool Online { get; set; }
        public bool Lock { get; set; }
        public int GeldigeLedigingen { get; set; }
        public int NoReads { get; set; }
        public int BlacklistContainers { get; set;  }
        public int TotaalKg { get; set; }
        public enum Diftar
        {
            Vrijgave = 0,
            Selectief = 1,
        };
        public DateTime? CreateDatum { get; set; }
        public DateTime? UpdateDatum { get; set; }
    }
}
