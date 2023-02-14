using System.Globalization;

namespace Domain
{
    public record SwimLength
    {
        public SwimLength(FormSwimLength formSwimLength)
        {
            this.ConvertFormSwimLengthToSwimLength(formSwimLength);
        }

        public DateTime SwimDate { get; set; }
        public DateTime SwimTime { get; set; }
        public int SetNumber { get; set; }
        public string Set { get; set; } = string.Empty;
        public int Interval { get; set; }
        public int Length { get; set; }
        public string Stroke { get; set; } = string.Empty;
        public TimeSpan MoveTime { get; set; }
        public TimeSpan RestTime { get; set; }
        public TimeSpan CumulativeTime { get; set; }
        public int Distance { get; set; }
        public int CumulativeDistance { get; set; }
        public double AvgDPS { get; set; }
        public TimeSpan Pace100 { get; set; }
        public TimeSpan Pace50 { get; set; }
        public int SWOLF { get; set; }
        public int AvgStrkRatestrkmin { get; set; }
        public int StrkCount { get; set; }
        public int AvgStrkCountLen { get; set; }
        public int Calories { get; set; }
        public double TotalMoveSeconds { get; set; }
        public double TotalRestSeconds { get; set; }

        public void ConvertFormSwimLengthToSwimLength(FormSwimLength formSwimLength)
        {
            this.Length = formSwimLength.Length;
            this.Set = formSwimLength.Set;
            this.Calories = formSwimLength.Calories;
            this.AvgDPS = formSwimLength.AvgDPS;
            this.CumulativeDistance = formSwimLength.CumulativeDistance;
            this.CumulativeTime = this.ConvertStringToTimeSpan(formSwimLength.CumulativeTime);
            this.MoveTime = this.ConvertStringToTimeSpan(formSwimLength.MoveTime);
            this.RestTime = this.ConvertStringToTimeSpan(formSwimLength.RestTime);
            this.Stroke = formSwimLength.Stroke;
            this.StrkCount = formSwimLength.StrkCount;
            this.SetNumber = formSwimLength.SetNumber;
            this.AvgStrkCountLen = formSwimLength.AvgStrkCountLen;
            this.AvgStrkRatestrkmin = formSwimLength.AvgStrkRatestrkmin;
            this.Interval = formSwimLength.Interval;
            this.Distance = formSwimLength.Distance;
            this.Pace100 = this.ConvertStringToTimeSpan(formSwimLength.Pace100);
            this.Pace50 = this.ConvertStringToTimeSpan(formSwimLength.Pace50);
            this.SWOLF = formSwimLength.SWOLF;
            this.SwimDate = formSwimLength.SwimDate;
            this.SwimTime = formSwimLength.SwimTime;
            this.TotalMoveSeconds = this.MoveTime.TotalSeconds;
            this.TotalRestSeconds = this.RestTime.TotalSeconds;
        }

        private TimeSpan ConvertStringToTimeSpan(string str)
            => TimeSpan.ParseExact(str, @"mm\:ss\.f", CultureInfo.InvariantCulture);
    }
}
