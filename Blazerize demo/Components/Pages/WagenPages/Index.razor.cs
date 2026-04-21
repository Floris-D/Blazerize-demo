using Blazerize_demo.Data;
using Blazerize_demo.Models;
using Blazorise.DataGrid;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.EntityFrameworkCore;


namespace Blazerize_demo.Components.Pages.WagenPages
{
    public partial class Index
    {
        [Inject]
        public IDbContextFactory<WagensContext> DbFactory { get; set; }
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
            using (var db = new WagensContext())
            {
                var wagens = await db.Wagens.OrderBy(w => w.Kenteken).ToListAsync();
                return wagens;
            }
        }
    }
}
