using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class StreamHub: Hub
    {
        public static TimerManager timerManager;
        private Helper helper = new Helper();

        public StreamHub()
        {

        }
        public void UpdateParameters(int ms, int volume, bool live = false)
        {
            StopTimer();

            FinancialData[] dataArray = JsonConvert.DeserializeObject<List<FinancialData>>(helper.jsonData).ToArray();
            FinancialData[] newDataArray = new FinancialData[volume];
            newDataArray = helper.generatedata(dataArray, volume);
            var clients = Clients;
            var connection = Context.ConnectionId;

            if (live)
            {
                // With the sendasync expression we are sending the data to all clients subscribed to transferdata event.
                // Every client that has a listener to this event will receive the data.
                StreamHub.timerManager = new TimerManager(() =>
                {
                    helper.updateAllPrices(newDataArray);

                    Send(newDataArray, clients);
                }, ms);
            }
            else
            {
                StopTimer();
                Send(newDataArray, clients);
            }
        }
        public async Task Send(FinancialData[] array, IHubCallerClients c)
        {
            Debug.WriteLine("Items count: " + array.Length);

            await c.Caller.SendAsync("transferdata", array);
        }

        public void StopTimer()
        {
            if (StreamHub.timerManager != null) { 
                Console.WriteLine("StopTimer");
                timerManager.Stop(); 
            }
        }
    }
}
