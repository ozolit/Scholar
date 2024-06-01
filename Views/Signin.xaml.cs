using Newtonsoft.Json;
using Scholar.Model;
using Scholar.Services;
using Scholar.ViewModel;

namespace Scholar.Views;

public partial class Signin : ContentPage
{
    private bool _isPasswordVisible = false;
    private readonly IPersonServices _PersonServices;


    public Signin(SigninViewModel signinViewModel, IPersonServices PersonServices)
	{
		InitializeComponent();
		this.BindingContext = signinViewModel;
        _PersonServices = PersonServices;
	}

    private void OnTogglePasswordButtonClicked(object sender, EventArgs e)
    {
        _isPasswordVisible = !_isPasswordVisible;

        password.IsPassword = !_isPasswordVisible;

        TogglePasswordButton.ImageSource = _isPasswordVisible ? "Images/eyeicon.png":"Images/eyeiconclose.png";
    }

    private async void LoginButton(object sender, EventArgs e)
    {
        var userName = email.Text;
        var passwordTxt = password.Text;

        if(!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(passwordTxt))
        {
            var userDetails = await _PersonServices.LogUserIn(userName, passwordTxt);

            if (userDetails != null)
            {
                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }
                string userDetailsStr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailsStr);
                App.UserDetails = userDetails;
                await AppConstant.AddFlyoutMenuDetals(); 

            }
           
            else
                {
                await Shell.Current.DisplayAlert("Not Logined", "User name or password is not correct", "Ok");
               }
        }
        else
        {
            await Shell.Current.DisplayAlert("Data Needed", "None of the field will be empty", "Ok");
        }




    }


}