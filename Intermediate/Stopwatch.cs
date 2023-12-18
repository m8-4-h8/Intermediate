using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started.");
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running.");

            _stopTime = DateTime.Now;
            _isRunning = false;
            Console.WriteLine("Stopwatch stopped.");
        }

        public TimeSpan GetDuration()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is still running. Stop it first.");

            return _stopTime - _startTime;
        }
    }
}
