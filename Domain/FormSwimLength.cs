using CsvHelper.Configuration.Attributes;

namespace Domain
{
    public class FormSwimLength
    {
        [Name("Swim Date")]
        public DateTime SwimDate { get; set; }

        [Name("Swim Time")]
        public DateTime SwimTime { get; set; }

        [Name("Set #")]
        public int SetNumber { get; set; }

        [Name("Set")]
        public string Set { get; set; } = string.Empty;

        [Name("Interval (m)")]
        public int Interval { get; set; }

        [Name("Length (m)")]
        public int Length { get; set; }

        [Name("Strk")]
        public string Stroke { get; set; } = string.Empty;

        [Name("Move Time")]
        public string MoveTime { get; set; } = string.Empty;

        [Name("Rest Time")]
        public string RestTime { get; set; } = string.Empty;

        [Name("Cumul Time")]
        public string CumulativeTime { get; set; } = string.Empty;

        [Name("Dist (m)")]
        public int Distance { get; set; }

        [Name("Cumul Dist (m)")]
        public int CumulativeDistance { get; set; }

        [Name("Avg DPS")]
        public double AvgDPS { get; set; }

        [Name("Pace/100")]
        public string Pace100 { get; set; } = string.Empty;

        [Name("Pace/50")]
        public string Pace50 { get; set; } = string.Empty;

        [Name("SWOLF")]
        public int SWOLF { get; set; }

        [Name("Avg Strk Rate (strk/min)")]
        public int AvgStrkRatestrkmin { get; set; }

        [Name("Strk Count")]
        public int StrkCount { get; set; }

        [Name("Avg Strk Count/Len")]
        public int AvgStrkCountLen { get; set; }

        [Name("Calories")]
        public int Calories { get; set; }
    }
}