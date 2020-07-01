using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Oqtane.Modules;
using drakozero.Sliders.Models;
using System;

namespace drakozero.Sliders.Repository
{
    public class SliderRepository : ISliderRepository, IService
    {
        private readonly SliderContext _db;

        public SliderRepository(SliderContext context)
        {
            _db = context;
        }

        public IEnumerable<Slider> GetSliders(int ModuleId)
        {
            List<Slider> _sliders;
            try
            {
                _sliders= _db.Slider.Where(item => item.ModuleId == ModuleId).ToList<Slider>();

            }catch(Exception ex)
            {
                _sliders=new List<Slider>();
            }
            return _sliders;
        }

        public Slider GetSlider(int SliderId)
        {
            return _db.Slider.Find(SliderId);
        }

        public Slider AddSlider(Slider Slider)
        {
            _db.Slider.Add(Slider);
            _db.SaveChanges();
            return Slider;
        }

        public Slider UpdateSlider(Slider Slider)
        {
            _db.Entry(Slider).State = EntityState.Modified;
            _db.SaveChanges();
            return Slider;
        }

        public void DeleteSlider(int SliderId)
        {
            Slider Slider = _db.Slider.Find(SliderId);
            _db.Slider.Remove(Slider);
            _db.SaveChanges();
        }
    }
}
