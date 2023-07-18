using Microsoft.Maui.Controls.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_POC
{
    public class PinModel
    {
        public string Label { get; set; }
        public string Address { get; set; }
        public Location Location { get; set; }
        public ImageSource ImageSource { get; set; }
        public PinType Type { get; set; }
        public int? ID { get; set; }

        public PinModel(int id, string label, string address, PinType type, Location location)
        {
            this.ID = id;
            this.Label = label;
            this.Address = address;
            this.Type = type;
            this.Location = location;
        }
    }
}
