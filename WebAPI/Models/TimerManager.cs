using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class TimerManager
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private Action _action;

        public DateTime TimerStarted { get; set; }

        public TimerManager(Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(Execute, _autoResetEvent, 1000, 100);
            TimerStarted = DateTime.Now;
        }

        public void Execute(object stateInfo)
        {
            _action();
            if ((DateTime.Now - TimerStarted).Seconds > 50)
            {
                _timer.Dispose();
            }
        }
    }
}
