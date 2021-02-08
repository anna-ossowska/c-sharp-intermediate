using System;

namespace Exercise1
{
    class Stopwatch
    {
        private static DateTime _startTime;
        private static DateTime _stopTime;
        private static bool _doAgain;

        public static DateTime Start()
        {
            if (_doAgain == true)
            {
                throw new InvalidOperationException("You can start only once.");
            }     
            _doAgain = true;
            return _startTime = DateTime.Now;
        }

        public static TimeSpan Stop()
        {
            if (_doAgain == false)
            {
                throw new InvalidOperationException("You can stop only once.");
            }
            _stopTime = DateTime.Now;
            _doAgain = false;
            return _stopTime - _startTime;
        }
    }
}




