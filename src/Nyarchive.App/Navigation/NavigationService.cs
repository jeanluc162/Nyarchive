using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyarchive.App.Navigation
{
    public class NavigationService : INavigationService
    {
        readonly IServiceProvider _services;
        readonly ILogger<NavigationService> _logger;
        protected INavigation Navigation
        {
            get
            {
                INavigation? navigation = Application.Current?.MainPage?.Navigation;
                if (navigation is not null)
                    return navigation;
                else
                {
                    _logger.LogCritical("{0} was Null!", nameof(navigation));
                    return null;
                }
            }
        }
        public NavigationService(IServiceProvider services, ILogger<NavigationService> logger)
        {
            _logger = logger;
            _services = services;
        }
        private Task NavigateToPage<T>() where T : Page
        {
            var page = ResolvePage<T>();
            if (page is not null)
                return Navigation.PushAsync(page, true);
            throw new InvalidOperationException($"Unable to resolve type {typeof(T).FullName}");
        }
        private T? ResolvePage<T>() where T : Page
            => _services.GetService<T>();

        public Task NavigateBack()
        {
            if (Navigation.NavigationStack.Count > 1)
                return Navigation.PopAsync();
            throw new InvalidOperationException("No pages to navigate back to!");
        }
    }
}
