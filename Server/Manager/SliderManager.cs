using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Oqtane.Modules;
using Oqtane.Models;
using Oqtane.Infrastructure;
using Oqtane.Repository;
using drakozero.Sliders.Models;
using drakozero.Sliders.Repository;

namespace drakozero.Sliders.Manager
{
    public class SliderManager : IInstallable, IPortable
    {
        private ISliderRepository _Sliders;
        private ISqlRepository _sql;

        public SliderManager(ISliderRepository Sliders, ISqlRepository sql)
        {
            _Sliders = Sliders;
            _sql = sql;
        }

        public bool Install(Tenant tenant, string version)
        {
            return _sql.ExecuteScript(tenant, GetType().Assembly, "drakozero.Sliders." + version + ".sql");
        }

        public bool Uninstall(Tenant tenant)
        {
            return _sql.ExecuteScript(tenant, GetType().Assembly, "drakozero.Sliders.Uninstall.sql");
        }

        public string ExportModule(Module module)
        {
            string content = "";
            List<Slider> Sliders = _Sliders.GetSliders(module.ModuleId).ToList();
            if (Sliders != null)
            {
                content = JsonSerializer.Serialize(Sliders);
            }
            return content;
        }

        public void ImportModule(Module module, string content, string version)
        {
            List<Slider> Sliders = null;
            if (!string.IsNullOrEmpty(content))
            {
                Sliders = JsonSerializer.Deserialize<List<Slider>>(content);
            }
            if (Sliders != null)
            {
                foreach(Slider Slider in Sliders)
                {
                    Slider _Slider = new Slider();
                    _Slider.ModuleId = module.ModuleId;
                    _Slider.Name = Slider.Name;
                    _Sliders.AddSlider(_Slider);
                }
            }
        }
    }
}