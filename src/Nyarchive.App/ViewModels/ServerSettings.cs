using Nyarchive.App.Navigation;
using Nyarchive.App.RestApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyarchive.App.ViewModels
{
    public class ServerSettings : ViewModelBase
    {
        public String Url
        {
            get
            {
                return _nyarchiveClient.BaseUrl;
            }
            set
            {
                if(_nyarchiveClient.BaseUrl != value)
                {
                    _nyarchiveClient.BaseUrl = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        private String _Username;
        public String Username
        {
            get { return _Username; }
            set
            {
                if(_Username != value)
                {
                    _Username = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        private String _Password;
        public String Password
        {
            get { return _Password; }
            set
            {
                if (_Password != value)
                {
                    _Password = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public Command ConnectCommand
            => new Command(async () =>
            {
                var token = await _nyarchiveClient.ApiAuthenticateLoginAsync(Username, Password);
            });
        public ServerSettings(NyarchiveClient nyarchiveClient, INavigationService navigationService) : base(nyarchiveClient, navigationService)
        {
        }
    }
}
