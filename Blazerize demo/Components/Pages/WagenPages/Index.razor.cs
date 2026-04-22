using Blazerize_demo.Data;
using Blazerize_demo.Models;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Configuration;


namespace Blazerize_demo.Components.Pages.WagenPages
{
    public partial class Index(IDbContextFactory<WagensContext> dbContextFactory)
    {
        [Inject]
        private IDbContextFactory<WagensContext> _contextFactory { get; set; }
        private DateTime SelectedDate;
        private List<Wagen> Wagens;

        protected override async Task OnInitializedAsync()
        {
            SelectedDate = DateTime.Now;
            Wagens = await GetAllWagens();
            await base.OnInitializedAsync();
        }

        protected async Task OnReadData(DataGridReadDataEventArgs<Wagen> e)
        {
            Wagens = await GetAllWagens();
        }

        public async Task<List<Wagen>> GetAllWagens()
        {
            using (var conn = _contextFactory.CreateDbContext())
            {
                var wagens = await conn.Wagens.OrderBy(w => w.Kenteken)
                    .Include(wagen => wagen.Datums)
                    .Include(wagen => wagen.Labels)
                    .ToListAsync();
                return wagens;
            }
        }
    }
}
