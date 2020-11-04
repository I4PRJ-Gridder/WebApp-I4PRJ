using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public interface IRepository
    {
        List<PixelPlacement> pixelPlacements { get; }
        PixelPlacement this[long id] { get; }
        PixelPlacement AddPixelPlacement(PixelPlacement placement);

    }
}