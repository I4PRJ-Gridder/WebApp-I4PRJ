using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PixelPlacement
    {
        public long PixelPlacementID { get; set; } //unique identifier for the user
        //public string ClientConnectionString { get; set; } //IP of connected user
        public Int32 X { get; set; } //x-coord
        public Int32 Y { get; set; } //y-coord

        public char color { get; set; }
        //private DateTime obj { get; set; } //time stamp object.
    }
}