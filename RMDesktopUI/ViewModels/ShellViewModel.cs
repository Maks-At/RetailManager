using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace RMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            Activate();
        }

        private async void Activate()
        {
            await ActivateItemAsync(IoC.Get<LoginViewModel>(), new CancellationToken());
            Console.WriteLine("Login view activated");
        }
    }
}
