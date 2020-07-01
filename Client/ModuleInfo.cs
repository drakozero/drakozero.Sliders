using Oqtane.Models;
using Oqtane.Modules;

namespace drakozero.Sliders
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Slider",
            Description = "Slider",
            Version = "1.0.0",
            ServerManagerType = "drakozero.Sliders.Manager.SliderManager, drakozero.Sliders.Server.Oqtane",
            ReleaseVersions = "1.0.0",
            Dependencies = "drakozero.Sliders.Shared.Oqtane"
        };
    }
}
