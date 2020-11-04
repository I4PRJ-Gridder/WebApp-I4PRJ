using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PixelPlacementDto //DTO = Data Transfer Object
    {
        //public string ClientConnectionString { get; set; } //IP of connected user
        public int x { get; set; } //x-coord
        public int y { get; set; } //y-coord
        public char color { get; set; }
        private DateTime obj { get; set; } //time stamp object.
    }
}