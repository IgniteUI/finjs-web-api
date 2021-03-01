using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class StreamHub: Hub
    {
        public async Task BroadcastData(FinancialData[] data) =>
            await Clients.All.SendAsync("broadcastdata", data);
    }
}
