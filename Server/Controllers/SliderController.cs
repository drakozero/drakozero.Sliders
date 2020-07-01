using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Oqtane.Shared;
using Oqtane.Enums;
using Oqtane.Infrastructure;
using drakozero.Sliders.Models;
using drakozero.Sliders.Repository;
using Microsoft.AspNetCore.Http;
using System;

namespace drakozero.Sliders.Controllers
{
    [Route("{site}/api/[controller]")]
    public class SliderController : Controller
    {
        private readonly ISliderRepository _Sliders;
        private readonly ILogManager _logger;
        private int _entityId = -1; // passed as a querystring parameter for authorization and used for validation

        public SliderController(ISliderRepository Sliders, ILogManager logger, IHttpContextAccessor httpContextAccessor)
        {
            _Sliders = Sliders;
            _logger = logger;
            if (httpContextAccessor.HttpContext.Request.Query.ContainsKey("entityid"))
            {
                _entityId = int.Parse(httpContextAccessor.HttpContext.Request.Query["entityid"]);
            }

        }

        // GET: api/<controller>?moduleid=x
        [HttpGet]
        [Authorize(Policy = "ViewModule")]
        public IEnumerable<Slider> Get(string moduleid)
        {
            return _Sliders.GetSliders(int.Parse(moduleid));
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [Authorize(Policy = "ViewModule")]
        public Slider Get(int id)
        {
            return _Sliders.GetSlider(id);
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize(Policy = "EditModule")]
        public Slider Post([FromBody] Slider Slider)
        {
            if (ModelState.IsValid && Slider.ModuleId==_entityId)
            {
                Slider = _Sliders.AddSlider(Slider);
                _logger.Log(LogLevel.Information, this, LogFunction.Create, "Slider Added {Slider}", Slider);
            }
            return Slider;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [Authorize(Policy = "EditModule")]
        public Slider Put(int id, [FromBody] Slider Slider)
        {
            if (ModelState.IsValid && Slider.ModuleId == _entityId)
            {
                Slider = _Sliders.UpdateSlider(Slider);
                _logger.Log(LogLevel.Information, this, LogFunction.Update, "Slider Updated {Slider}", Slider);
            }
            return Slider;
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [Authorize(Policy = "EditModule")]
        public void Delete(int id)
        {
            var _slide= _Sliders.GetSlider(id);
            if (_slide.ModuleId == _entityId)
            {
                _Sliders.DeleteSlider(id);
                _logger.Log(LogLevel.Information, this, LogFunction.Delete, "Slider Deleted {SliderId}", id);
            }
        }
    }
}
