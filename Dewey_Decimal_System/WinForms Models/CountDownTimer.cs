using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Dewey_Decimal_System
{
    public class CountDownTimer
    {
        // Stopwatch for measuring elapsed time
        public Stopwatch _stpWatch = new Stopwatch();

        // Action to execute when time changes
        public Action TimeChanged;

        // Action to execute when the countdown finishes
        public Action CountDownFinished;


        // Check if the timer is currently running
        public bool IsRunnign => timer.Enabled;

        // Interval in milliseconds between timer ticks
        public int StepMs
        {
            get => timer.Interval;
            set => timer.Interval = value;
        }

        private Timer timer = new Timer(); // Windows Forms Timer for UI updates

        private TimeSpan _max = TimeSpan.FromMilliseconds(30000); // Maximum time for the countdown


        // Calculate the time remaining based on the maximum time and elapsed time
        public TimeSpan TimeLeft => _max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds > 0 ? TimeSpan.FromMilliseconds(_max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds) : TimeSpan.FromMilliseconds(0);

        // Format time remaining as a string (seconds)
        private bool _mustStop => _max.TotalMilliseconds - _stpWatch.ElapsedMilliseconds < 0;

        public string TimeLeftStr => TimeLeft.ToString(@"ss");

        // Format time remaining as a string (minutes:seconds.milliseconds)
        public string TimeLeftMsStr => TimeLeft.ToString(@"mm\:ss\.fff");

        private void TimerTick(object sender, EventArgs e)
        {
            TimeChanged?.Invoke();

            if (_mustStop)
            {
                CountDownFinished?.Invoke();
                _stpWatch.Stop();
                timer.Enabled = false;
            }
        }

        public CountDownTimer(int min, int sec)
        {
            SetTime(min, sec);
            Init();
        }

        public CountDownTimer(TimeSpan ts)
        {
            SetTime(ts);
            Init();
        }

        public CountDownTimer()
        {
            Init();
        }

        private void Init()
        {
            StepMs = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        public void SetTime(TimeSpan ts)
        {
            _max = ts;
            TimeChanged?.Invoke();
        }

        // Format time remaining as a string (seconds)

        public void SetTime(int min, int sec = 0) => SetTime(TimeSpan.FromSeconds(min * 60 + sec));

        // Start the countdown timer
        public void Start()
        {
            timer.Start(); // Start the Windows Forms Timer
            _stpWatch.Start(); // Start the stopwatch to measure elapsed time
        }

        // Pause the countdown timer
        public void Pause()
        {
            timer.Stop(); // Stop the Windows Forms Timer
            _stpWatch.Stop(); // Stop the stopwatch
        }

        // Stop and reset the countdown timer
        public void Stop()
        {
            Reset(); // Reset the stopwatch
            Pause(); // Pause the timer
        }

        // Reset the elapsed time to zero
        public void Reset()
        {
            _stpWatch.Reset(); // Reset the stopwatch
        }

        // Reset the elapsed time to zero and restart the countdown timer
        public void Restart()
        {
            _stpWatch.Reset(); // Reset the stopwatch
            timer.Start(); // Start the Windows Forms Timer
        }

        // Dispose of the timer
        public void Dispose() => timer.Dispose();
    }
}
//--------------------------------------------------------------------Kaylox--------------------------------------------------//   
