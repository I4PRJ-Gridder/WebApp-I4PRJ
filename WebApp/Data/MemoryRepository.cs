using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public class MemoryRepository : IRepository
    {
        private static MemoryRepository instance = null;
        private readonly Dictionary<long, PixelPlacement> items;

        private MemoryRepository()
        {
            items = new Dictionary<long, PixelPlacement>();
            new List<PixelPlacement> {
                new PixelPlacement {X = 1, Y = 2 },
                new PixelPlacement {X = 2, Y = 2},
                new PixelPlacement {X = 3, Y = 2}
            }.ForEach(r => AddPixelPlacement(r));
        }


        //Implements singleton design pattern
        static public MemoryRepository GetInstance()
        {
            if (instance == null)
                instance = new MemoryRepository();
            return instance;
        }

        public List<PixelPlacement> pixelPlacements { get; }

        //this[long id] overload af index operatoren
        public PixelPlacement this[long id] => items.ContainsKey(id) ? items[id] : null;

        public List<PixelPlacement> PixelPlacements => items.Values.ToList();

        public PixelPlacement AddPixelPlacement(PixelPlacement placement)
        {
            if (placement.PixelPlacementID == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; }
                placement.PixelPlacementID = key;
            }

            items[placement.PixelPlacementID] = placement;
            return placement;
        }

        public PixelPlacement UpdatePixelPlacement(PixelPlacement placement)
            => AddPixelPlacement(placement);
    }
}