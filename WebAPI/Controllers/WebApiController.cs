using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebApiController : ControllerBase
    {
        private readonly IHubContext<StreamHub> _hubContext;
        private Timer _timer;

        public TimerManager timerManager;

        /// <summary>
        /// We are using the IHubContext and creating its instance via dependency injection. By using this instance object we are able to access and call the hub methods.
        /// </summary>
        /// <param name="hub"></param>
        public WebApiController(IHubContext<StreamHub> hub)
        {
            _hubContext = hub;
        }

        public IActionResult Get()
        {
            Helper helper = new Helper();
            int recordsCount = 1000;
            FinancialData[] dataArray = JsonConvert.DeserializeObject<List<FinancialData>>(helper.jsonData).ToArray();
            FinancialData[] newDataArray = new FinancialData[recordsCount];

            // Send initial 1000 rows of data
            newDataArray = helper.generatedata(dataArray, recordsCount);
            _hubContext.Clients.All.SendAsync("transferdata", newDataArray.OrderBy(item => item.ID).ToArray());

            return Ok(new { Message = "Request Completed" });
        }
    }
}
