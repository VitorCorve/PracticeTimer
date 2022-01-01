using System;

namespace WPFTimer.Model
{
    [Serializable]
    public class JsonDataModel
    {
        public int SecondsTotal { get; set; }
        public int MinutesTotal { get; set; }
        public int HoursTotal { get; set; }
        public int WeeksTotal { get; set; }
        public int MontsTotal { get; set; }
        public int HoursInThisWeek { get; set; }
        public int HoursInThisMonth { get; set; }
        public int SecondsToday { get; set; }
        public int MinutesToday { get; set; }
        public int HoursToday { get; set; }
        public DateTime LastActivity { get; set; }
    }
}
