using System;

namespace Timer{
    public class Stopwatch
    {
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
        private bool _inProgress = false;

        public void Start()
        {
            if (this._inProgress) {
                throw new InvalidOperationException("timer already has been started");
            };

            this._inProgress = true;
            this.StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!this._inProgress) return;

            TimeSpan currentDiff = DateTime.Now - this.StartTime;
            this.Duration += currentDiff;
            this._inProgress = false;

            this.ShowDuration(this.Duration);
        }

        private void ShowDuration(TimeSpan duration)
        {
            Console.WriteLine("Current duration is ${0}", duration);
        }

        public void WhatTimeIsIt()
        {
            this.ShowDuration(this.Duration);
        }
    }
}