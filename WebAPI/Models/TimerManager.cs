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
        private int updateInterval = 500;
        private Action _action;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        public TimerManager(Action action, int milliseconds)
        {
            _action = action;
            updateInterval = milliseconds;
            _timer = new Timer(Execute, _cts.Token, 0, updateInterval);
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
        }

        public void UpdateInterval(int interval)
        {
            updateInterval = interval;
            _timer.Change(0, interval);
        }

        public void Stop()
        {
            _cts.Cancel();
            _timer.Dispose();
        }

    }
}
