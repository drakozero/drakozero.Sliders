using BlazorStrap;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Oqtane.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace drakozero.Sliders.Server
{
    class BlazorStrapService : IClientStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddBootstrapCss().
            services.AddBootstrapCss();
        }
    }
}
