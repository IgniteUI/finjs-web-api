# SignalR Real-time ASP.NET 

The **finjs-web-api** is a Real-time ASP.NET API built with [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr)

# Demo location
Both Financial Grid and DockManages with dynamic creation of Grids can be found [here](https://www.infragistics.com/products/ignite-ui-angular/angular/components/grid/live-data).

# Usage

- The updated records count is based on the requested data volume (10% of the requested data). The point of this functionality is to mimic as close as possible a real-time data update. 
- Two models FinancialData and PercentChange
- There is a fallback logic for the case when the end point API is not reachable. In that case a local data would be used.

Establish hub connection
```ts
this.hubConnection = new signalR.HubConnectionBuilder()
    .configureLogging(signalR.LogLevel.Trace)
    .withUrl('https://www.infragistics.com/angular-apis/webapi/streamHub')
    .build();
this.hubConnection
    .start()
    .then(() => {
        this.hasRemoteConnection = true;
        this.registerSignalEvents();
        this.broadcastParams(interval, volume, live, updateAll);
    })
    .catch(() => {
    ...
```

Use `updateparameters` service method in order to change the data update frequency, the data volume and whether to stop the live feed.

```ts
this.hubConnection.invoke('updateparameters', frequency, volume, live, updateAll)
    .then(() => console.log('requestLiveData', volume))
    .catch(err => {
        console.error(err);
    });
```

Another way to stop the live feed is by using the `StopTimer` service method

```ts
this.hubConnection.invoke('StopTimer')
    .catch(err => console.error(err));
```