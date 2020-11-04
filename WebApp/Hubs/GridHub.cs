using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebApp.Hubs
{
    public class GridHub : Hub
    {
        //Real time funktionalitet
        public async Task SetPixel(Int32 x, Int32 y, char color)
        {
            await Clients.All.SendAsync("PlacePixel", x, y, color);
        }
    }
}
