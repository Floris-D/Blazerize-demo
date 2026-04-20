namespace Blazerize_demo.Models
{
    public class Wagen
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Kenteken { get; set; } = string.Empty;
        public string Versie { get; set; } = string.Empty;
        public IEnumerable<string>? Labels { get; set; }
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

    }
}
