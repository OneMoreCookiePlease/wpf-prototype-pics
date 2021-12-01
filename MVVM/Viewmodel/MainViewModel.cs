using Pics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pics;

namespace Pics.MVVM.Viewmodel
{
    class MainViewModel : ObservableObject
    {


        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AnotherViewCommand { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public AnotherViewModel AnotherVM { get; set; }


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();   
            AnotherVM = new AnotherViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;

            });

            AnotherViewCommand = new RelayCommand(o =>
            {
                CurrentView = AnotherVM;

            });


        }


    }
}
