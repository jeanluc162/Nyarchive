using Nyarchive.App.Navigation;
using Nyarchive.App.RestApi;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Nyarchive.App.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public virtual Task OnNavigatingTo(object? parameter)
            => Task.CompletedTask;
        public virtual Task OnNavigatedFrom(bool isForwardNavigation)
            => Task.CompletedTask;
        public virtual Task OnNavigatedTo()
            => Task.CompletedTask;

        protected readonly NyarchiveClient _nyarchiveClient;
        protected readonly INavigationService _navigationService;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelBase(NyarchiveClient nyarchiveClient, INavigationService navigationService)
        {
            _nyarchiveClient = nyarchiveClient;
            _navigationService = navigationService;
        }
        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
