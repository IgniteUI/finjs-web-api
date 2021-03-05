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
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        public DateTime TimerStarted { get; set; }

        public TimerManager(Action action, int milliseconds = 100)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            // It will start with 0 seconds delay for 100ms interval
            _timer = new Timer(Execute, _cts.Token, 0, milliseconds);
            TimerStarted = DateTime.Now;
        }

        /// <summary>
        /// We are using an Action delegate to execute the passed callback function every X seconds.
        /// The timer will make a X seconds pause before the first execution.
        /// Finally, we just create a sixty seconds time slot for execution, to avoid limitless timer loop.
        /// </summary>
        /// <param name="stateInfo"></param>
        public void Execute(object stateInfo)
        {
            _action();
            // Run for 10 minutes or stop it manually
            if ((DateTime.Now - TimerStarted).Seconds > 600)
            {
                _timer.Dispose();
            }
        }

        public void Stop()
        {
            _cts.Cancel();
            _timer.Dispose();
        }

    }
}
