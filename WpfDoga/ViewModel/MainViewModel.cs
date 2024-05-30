using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfDoga.Command;
using WpfDoga.View;

namespace WpfDoga.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged(); }
        }

        HomeView homeView;
        QuantityView quantityView;
        WpfDoga.View.DataView dataView;

        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand openHOme { get; }
        public RelayCommand QuantityView { get; }
        public RelayCommand DataView { get; }

        public MainViewModel()
        {
            homeView = new HomeView();
            quantityView = new QuantityView();
            dataView = new WpfDoga.View.DataView();

            openHOme = new RelayCommand(X => CurrentView = homeView);
            QuantityView = new RelayCommand(X => CurrentView = quantityView);
            DataView = new RelayCommand(X => CurrentView = dataView);

            CurrentView = homeView;
        }
        private void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
