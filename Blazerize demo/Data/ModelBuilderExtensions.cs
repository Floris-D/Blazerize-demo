using Blazerize_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazerize_demo.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wagen>(b =>
            {
                DateTime date = new DateTime(2026, 4, 21);
                b.HasData(
                    new Wagen { Id = 1, Kenteken = "11-TST-1", Versie = "Test", CreateDatum = date, UpdateDatum = date, Diftar = Diftars.Vrijgave },
                    new Wagen { Id = 2, Kenteken = "22-TST-2", Versie = "Test", CreateDatum = date, UpdateDatum = date, Diftar = Diftars.Selectief },
                    new Wagen { Id = 3, Kenteken = "33-TST-3", Versie = "Test", CreateDatum = date, UpdateDatum = date, Diftar = Diftars.Vrijgave }
                );
                b.HasMany(d => d.Datums).WithOne(w => w.Wagen);
                b.HasMany(l => l.Labels).WithOne(w => w.Wagen);
            });

            modelBuilder.Entity<Label>(l =>
            {
                l.HasData(
                    new Label { Id = 1, WagenKey = 1, isActive = false, Name = "GFT" },
                    new Label { Id = 2, WagenKey = 1, isActive = true, Name = "PMD" },
                    new Label { Id = 3, WagenKey = 2, isActive = true, Name = "GFT" },
                    new Label { Id = 4, WagenKey = 2, isActive = true, Name = "PMD" },
                    new Label { Id = 5, WagenKey = 3, isActive = false, Name = "GFT" },
                    new Label { Id = 6 ,WagenKey = 3, isActive = false, Name = "PMD" }
                );
            });

            modelBuilder.Entity<Datum>(d =>
            {
                DateTime date1 = new DateTime(2026, 4, 20);
                DateTime date2 = new DateTime(2026, 4, 21);
                d.HasData(
                    new Datum { Id = 1, Date = date1, TotaalKg = 22, WagenKey = 1 },
                    new Datum { Id = 2, Date = date2, TotaalKg = 44, WagenKey = 1 },
                    new Datum { Id = 3, Date = date1, TotaalKg = 33, WagenKey = 2 },
                    new Datum { Id = 4,  Date = date2, TotaalKg = 55, WagenKey = 2 },
                    new Datum { Id = 5,  Date = date1, TotaalKg = 12, WagenKey = 3 },
                    new Datum { Id = 6,  Date = date2, TotaalKg = 32, WagenKey = 3 }
                );
            });
        }
    }
}
