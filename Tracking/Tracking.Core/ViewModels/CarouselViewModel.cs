using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading.Forms;
using MvvmCross.Core.ViewModels;
using Xamarin.Forms;

namespace Tracking.Core.ViewModels
{
    public class CarouselViewModel : MvxViewModel
    {
        public override Task Initialize()
        {
            MyItemsSource = new ObservableCollection<View>()
            {
                new Image { Source = "c1.jpg", Aspect = Aspect.AspectFill },
                new Image { Source = "c2.jpg", Aspect = Aspect.AspectFill },
                new Image { Source = "c3.jpg", Aspect = Aspect.AspectFill }
            };
            
            MyCommand = new Command(() =>
            {
                Debug.WriteLine("Position selected.");
            });

            return base.Initialize();
        }

        ObservableCollection<View> _myItemsSource;

        public ObservableCollection<View> MyItemsSource
        {
            set => SetProperty(ref _myItemsSource, value);
            get => _myItemsSource;
        }
        
        public Command MyCommand { protected set; get; }
    }
}
