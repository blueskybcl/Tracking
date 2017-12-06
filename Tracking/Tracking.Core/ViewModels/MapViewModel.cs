using System;
using MvvmCross.Core.ViewModels;

namespace Tracking.Core.ViewModels
{
    public class MapViewModel : MvxViewModel
    {
        private string _address;
        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        private IMvxCommand _addressSearchCommand;
        public IMvxCommand AddressSearchCommand => _addressSearchCommand ?? (_addressSearchCommand = new MvxCommand(ExecuteAddressSearchCommand));

        private void ExecuteAddressSearchCommand()
        {
            
        }
    }
}
