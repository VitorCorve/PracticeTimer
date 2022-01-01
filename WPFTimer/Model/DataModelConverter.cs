namespace WPFTimer.Model
{
    public class DataModelConverter
    {
        public static JsonDataModel Convert(DataModel data)
        {
            JsonDataModel json = new JsonDataModel
            {
                SecondsTotal = data.SecondsTotal,
                MinutesTotal = data.MinutesTotal,
                HoursTotal = data.HoursTotal,
                WeeksTotal = data.WeeksTotal,
                MontsTotal = data.MontsTotal,
                HoursInThisWeek = data.HoursInThisWeek,
                HoursInThisMonth = data.HoursInThisMonth,
                SecondsToday = data.SecondsToday,
                MinutesToday = data.MinutesToday,
                HoursToday = data.HoursToday,
                LastActivity = data.LastActivity,
            };
            return json;
        }
    }
}
