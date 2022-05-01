using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyarchive.App.Navigation
{
    public interface INavigationService
    {
        Task NavigateBack();
    }
}
