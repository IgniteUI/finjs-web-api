using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class StreamHub: Hub
    {
        public static IDictionary<string, TimerManager> clientConnections =
            new Dictionary<string, TimerManager>();
        private static FinancialData[] newDataArray;
        private Helper helper = new Helper();

        public StreamHub() { }

        public async void UpdateParameters(int interval, int volume, bool live = false, bool updateAll = true)
        {
            FinancialData[] dataArray = JsonConvert.DeserializeObject<List<FinancialData>>(helper.jsonData).ToArray();
            newDataArray = helper.generatedata(dataArray, volume);
            var connection = Context.ConnectionId;
            var clients = Clients;

            if (live)
            {
                if (!clientConnections.ContainsKey(connection))
                {
                    clientConnections.Add(connection, new TimerManager(async() =>
                    {
                        var client = clients.Client(connection);
                        if (updateAll)
                        {
                            helper.updateAllPrices(newDataArray);
                        }
                        else
                        {
                            helper.updateRandomPrices(newDataArray);
                        }
                        await Send(newDataArray, client, connection);
                    }, interval));
                } else
                {
                    clientConnections[connection].Stop();
                    clientConnections[connection] = new TimerManager(async () =>
                    {
                        var client = clients.Client(connection);
                        if (updateAll)
                        {
                            helper.updateAllPrices(newDataArray);
                        }
                        else
                        {
                            helper.updateRandomPrices(newDataArray);
                        }
                        await Send(newDataArray, client, connection);
                    }, interval);
                }
            }
            else
            {
                var client = clients.Client(connection);
                await Send(newDataArray, client, connection);
            }
        }

        public async Task Send(FinancialData[] array, IClientProxy client, string connection)
        {
            await client.SendAsync("transferdata", array);
        }

        public void StopTimer()
        {
            TimerManager timerManager;
            clientConnections.TryGetValue(Context.ConnectionId, out timerManager);
            if (timerManager != null) {
                timerManager.Stop(); 
            }
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            StopTimer();
            clientConnections.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

    }
}
