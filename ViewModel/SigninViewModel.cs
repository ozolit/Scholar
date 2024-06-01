using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Scholar.Model;
using Scholar.Services;
using Scholar.Views;
using Scholar.Views.Applicant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.ViewModel
{
    public partial class SigninViewModel:ObservableObject
    {
        private readonly IPersonServices _personServices;
        public SigninViewModel(IPersonServices personServices)
        {
            _personServices = personServices;
            LoginDetails = new Person();
        }

        [ObservableProperty]
        public Person _LoginDetails;


        [RelayCommand]
        public async Task LoginPerson()
        {

            var userId = await _personServices.LogUserIn(LoginDetails.Email, LoginDetails.Password);
            if (userId != null)
            {
                await Shell.Current.GoToAsync(nameof(ApplicantDashboard), new Dictionary<string, object> { { "userId", userId } });
                //await Shell.Current.Navigation.PushAsync(new ShellNavigationState("dashboard", new Dictionary<string, object> { { "userId", userId } }));
            }

        
            else
            {
                await Shell.Current.DisplayAlert("Not Logined", "User name or password is not correct", "Ok");


            }
        }


        [RelayCommand]
        public  async void OpenSigninPage()
        {
            await Shell.Current.GoToAsync(nameof(Signin));
        }


       
        
    }
}
