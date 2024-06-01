using Newtonsoft.Json;
using Scholar.Model;
using System.ComponentModel;

namespace Scholar.Views.Applicant;

public partial class ApplicantDashboard : ContentPage
{
	public ApplicantDashboard()
	{
        CheckUserDetails();
		InitializeComponent();
        if (App.UserDetails != null)
        {
            firstName.Text = App.UserDetails.FirstName;
            lastName.Text = App.UserDetails.LastName;
            middleName.Text = App.UserDetails.MiddleName;
            email.Text = App.UserDetails.Email;
            personTypeId.Text = App.UserDetails.PersonTypeId.ToString(); 

        }
    }


    private async void SubmitBiodata(object sender, EventArgs e)

    {
        await Shell.Current.DisplayAlert("Data Needed", "None of the field will be empty", "Ok");

    }

    private async void CheckUserDetails()
	{
		string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");
		if(string.IsNullOrWhiteSpace(userDetailsStr))
		{
			await Shell.Current.GoToAsync(nameof(Signin));
		}
		else
		{

			var userInfo = JsonConvert.DeserializeObject<Person>(userDetailsStr);


        }
	}




}