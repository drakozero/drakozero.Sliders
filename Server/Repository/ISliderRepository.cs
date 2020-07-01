using System.Collections.Generic;
using drakozero.Sliders.Models;

namespace drakozero.Sliders.Repository
{
    public interface ISliderRepository
    {
        IEnumerable<Slider> GetSliders(int ModuleId);
        Slider GetSlider(int SliderId);
        Slider AddSlider(Slider Slider);
        Slider UpdateSlider(Slider Slider);
        void DeleteSlider(int SliderId);
    }
}
