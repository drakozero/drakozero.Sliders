using System;
using System.ComponentModel.DataAnnotations.Schema;
using Oqtane.Models;

namespace drakozero.Sliders.Models
{
    [Table("drakozeroSlider")]
    public class Slider : IAuditable
    {
        public int SliderId { get; set; }
        public int ModuleId { get; set; }
        public string Name { get; set; }
        public int  Source { get; set; }
        public string Alt { get; set; }
        public string Caption { get; set; }
        public string Header { get; set; }
        public string ActionLink { get; set; }
        public string ActionLinkTarget { get; set; }
        public bool Enabled { get; set; }
        public int Time { get; set; }
        public int Order { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
