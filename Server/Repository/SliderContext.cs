using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Oqtane.Modules;
using Oqtane.Repository;
using drakozero.Sliders.Models;

namespace drakozero.Sliders.Repository
{
    public class SliderContext : DBContextBase, IService
    {
        public virtual DbSet<Slider> Slider { get; set; }

        public SliderContext(ITenantResolver tenantResolver, IHttpContextAccessor accessor) : base(tenantResolver, accessor)
        {
            // ContextBase handles multi-tenant database connections
        }
    }
}
