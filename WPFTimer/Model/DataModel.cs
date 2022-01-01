using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFTimer.Model
{
    public class DataModel : INotifyPropertyChanged
    {
        public delegate void Notification();
        public event Notification HourSpend;
        private int _SecondsTotal, _MinutesTotal, _HoursTotal, _DaysTotal, _WeeksTotal, _MontsTotal, _HoursInThisWeek, _HoursInThisMonth, _SecondsToday, _MinutesToday, _HoursToday;
        public int SecondsTotal { get => _SecondsTotal; private set { _SecondsTotal = value; OnPropertyChanged(); } }
        public int MinutesTotal { get => _MinutesTotal; private set { _MinutesTotal = value; OnPropertyChanged(); } }
        public int HoursTotal { get => _HoursTotal; private set { _HoursTotal = value; OnPropertyChanged(); } }
        public int DaysTotal { get => _DaysTotal; private set { _DaysTotal = value; OnPropertyChanged(); } }
        public int WeeksTotal { get => _WeeksTotal; private set { _WeeksTotal = value; OnPropertyChanged(); } }
        public int MontsTotal { get => _MontsTotal; private set { _MontsTotal = value; OnPropertyChanged(); } }
        public int HoursInThisWeek { get => _HoursInThisWeek; private set { _HoursInThisWeek = value; OnPropertyChanged(); } }
        public int HoursInThisMonth { get => _HoursInThisMonth; private set { _HoursInThisMonth = value; OnPropertyChanged(); } }
        public int SecondsToday { get => _SecondsToday; private set { _SecondsToday = value; OnPropertyChanged(); } }
        public int MinutesToday { get => _MinutesToday; private set { _MinutesToday = value; OnPropertyChanged(); } }
        public int HoursToday { get => _HoursToday; private set { _HoursToday = value; OnPropertyChanged(); } }
        public DateTime LastActivity { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public DataModel(JsonDataModel json)
        {
            SecondsTotal = json.SecondsTotal;
            MinutesTotal = json.MinutesTotal;
            HoursTotal = json.HoursTotal;
            WeeksTotal = json.WeeksTotal;
            MontsTotal = json.MontsTotal;
            HoursInThisWeek = json.HoursInThisWeek;
            HoursInThisMonth = json.HoursInThisMonth;
            SecondsToday = json.SecondsToday;
            MinutesToday = json.MinutesToday;
            HoursToday = json.HoursToday;
            LastActivity = json.LastActivity;

            if (IsNewWeek())
            {
                HoursInThisWeek = 0;
            }
            ;
            if (IsNewMonth())
            {
                HoursInThisMonth = 0;
            }

            SetGlobalValues();
        }
        public void SpendTime()
        {
            ConvertValues();
            SecondsTotal++;
            SecondsToday++;
        }
        private bool IsNewWeek() => GetFirstDayOfWeek(DateTime.Now) > LastActivity;
        private bool IsNewMonth() => LastActivity.Month < DateTime.Now.Month;
        private void ConvertValues()
        {
            if (SecondsTotal == 59)
            {
                SecondsTotal = -1;
                MinutesTotal++;
            }
            if (MinutesTotal == 59)
            {
                MinutesTotal = -1;
                HoursTotal++;
                HoursInThisWeek++;
                HoursInThisMonth++;
                HourSpend?.Invoke();
            }
            if (HoursTotal == 23 && MinutesTotal == 59 && SecondsTotal == 59)
            {
                SetGlobalValues();
            }

            if (SecondsToday == 59)
            {
                SecondsToday = -1;
                MinutesToday++;
            }
            if (MinutesToday == 59)
            {
                MinutesToday = -1;
                HoursToday++;
                HourSpend?.Invoke();
            }
        }
        private DateTime GetFirstDayOfWeek(DateTime date)
        {
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(-1);
            }
            return date;
        }
        private void SetGlobalValues()
        {
            DaysTotal = HoursTotal / 24;
            WeeksTotal = DaysTotal / 7;
            MontsTotal = DaysTotal / 30;
        }
    }
}
