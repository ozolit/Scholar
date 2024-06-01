
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;
using Scholar.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.ViewModel
{
    public partial class AppShellVieqwModel : BaseViewModel
    {
        //[RelayCommand]
        private async void SignOut(object sender, EventArgs e)

         //async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails));
            }
            await Shell.Current.GoToAsync(nameof(Signin));
        }
    }
}
