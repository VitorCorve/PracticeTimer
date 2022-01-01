using GalaSoft.MvvmLight.Command;
using System;
using System.ComponentModel;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using WPFTimer.Model;

namespace WPFTimer.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool _IsOnPlayImageEnabled;
        private delegate void Action();
        private readonly SoundPlayer Player;
        private string _Statement;
        public event PropertyChangedEventHandler PropertyChanged;
        public string Statement { get => _Statement; set { _Statement = value; OnPropertyChanged(); } }
        public bool IsOnPlayImageEnabled { get => _IsOnPlayImageEnabled; set { _IsOnPlayImageEnabled = value; OnPropertyChanged(); } }
        public Counter CountService { get; private set; } = new();
        public RelayCommand Engage { get; set; }
        public RelayCommand Exit { get; set; }

        public MainWindowViewModel()
        {
            Player = new SoundPlayer(Environment.CurrentDirectory + "\\Data\\reload.wav");
            Player.Play();

            Statement = "Run";
            Engage = new RelayCommand(() =>
            {
                CountService.Engage();
                Statement = CountService.IsRunned ? Statement = "Stop" : Statement = "Run";
                IsOnPlayImageEnabled = CountService.IsRunned ? true : false;
            });

            Exit = new RelayCommand(() =>
            {
                Task.Run(() =>
                {
                    CountService.SaveData();
                }).ContinueWith(obj =>
                {
                    Environment.Exit(0);
                });
            });

            CountService.Model.HourSpend += PlaySound;
        }
        private void PlaySound() => Player.Play();
        private void OnPropertyChanged([CallerMemberName] string property = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
