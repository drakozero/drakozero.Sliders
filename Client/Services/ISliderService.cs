using System.Collections.Generic;
using System.Threading.Tasks;
using drakozero.Sliders.Models;

namespace drakozero.Sliders.Services
{
    public interface ISliderService 
    {
        Task<List<Slider>> GetSlidersAsync(int ModuleId);

        Task<Slider> GetSliderAsync(int SliderId, int ModuleId);

        Task<Slider> AddSliderAsync(Slider Slider, int ModuleId);

        Task<Slider> UpdateSliderAsync(Slider Slider, int ModuleId);

        Task DeleteSliderAsync(int SliderId, int ModuleId);
    }
}
