using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Oqtane.Modules;
using Oqtane.Services;
using Oqtane.Shared;
using drakozero.Sliders.Models;

namespace drakozero.Sliders.Services
{
    public class SliderService : ServiceBase, ISliderService, IService
    {
        private readonly SiteState _siteState;

        public SliderService(HttpClient http, SiteState siteState) : base(http)
        {
            _siteState = siteState;
        }

         private string Apiurl=> CreateApiUrl(_siteState.Alias, "Slider");

        public async Task<List<Slider>> GetSlidersAsync(int ModuleId)
        {
            List<Slider> Sliders = await GetJsonAsync<List<Slider>>($"{Apiurl}?moduleid={ModuleId}&entityid={ModuleId}");
            return Sliders.OrderBy(item => item.Name).ToList();
        }

        public async Task<Slider> GetSliderAsync(int SliderId, int ModuleId)
        {
            return await GetJsonAsync<Slider>($"{Apiurl}/{SliderId}?entityid={ModuleId}"); ;
        }

        public async Task<Slider> AddSliderAsync(Slider Slider, int ModuleId)
        {
            return await PostJsonAsync<Slider>($"{Apiurl}?entityid={ModuleId}", Slider);
        }

        public async Task<Slider> UpdateSliderAsync(Slider Slider, int ModuleId)
        {
            return await PutJsonAsync<Slider>($"{Apiurl}/{Slider.SliderId}?entityid={ModuleId}", Slider);
        }

        public async Task DeleteSliderAsync(int SliderId, int ModuleId)
        {
            await DeleteAsync($"{Apiurl}/{SliderId}?entityid={ModuleId}");
        }
    }
}
