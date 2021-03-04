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
        public TimerManager timerManager;
        private Helper helper = new Helper();

        public StreamHub()
        {

        }
        public void UpdateParameters(int ms, int volume)
        {
            StopTimer();

            FinancialData[] dataArray = JsonConvert.DeserializeObject<List<FinancialData>>(helper.jsonData).ToArray();
            FinancialData[] newDataArray = new FinancialData[volume];
            newDataArray = helper.generatedata(dataArray, volume);

            Debug.WriteLine("Ms: " + ms + ", Volume:" + volume);
            Send(newDataArray);

            // With the sendasync expression we are sending the data to all clients subscribed to transferdata event.
            // Every client that has a listener to this event will receive the data.
            //timerManager = new TimerManager(() =>
            //{
            //    helper.updateAllPrices(newDataArray);

            //    Send(newDataArray);
            //}, ms);
        }
        public async Task Send(FinancialData[] array)
        {
            Debug.WriteLine("Items count: " + array.Length);

            await Clients.Caller.SendAsync("transferdata", array);
        }

        public void StopTimer()
        {
            if (timerManager != null) { timerManager.Stop(); }
        }
    }
}
