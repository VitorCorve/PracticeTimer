using System.Timers;

namespace WPFTimer.Model
{
    public class Counter
    {
        private readonly DataHandler Handler = new();
        private readonly Timer CountTimer = new(1000);
        public bool IsRunned { get; set; }
        public DataModel Model { get; private set; }
        public Counter()
        {
            Model = new DataModel(Handler.GetData());
            CountTimer.Elapsed += TimerTick;
        }
        public void Engage()
        {
            if (CountTimer.Enabled)
            {
                CountTimer.Stop();
                IsRunned = false;
            }
            else
            {
                CountTimer.Start();
                IsRunned = true;
            }
        }
        public void Start() => CountTimer.Start();
        public void Stop() => CountTimer.Stop();
        private void TimerTick(object sender, ElapsedEventArgs e) => Model.SpendTime();
        public void SaveData()
        {
            JsonDataModel converted = DataModelConverter.Convert(Model);
            Handler.SaveData(converted);
        }
    }
}
