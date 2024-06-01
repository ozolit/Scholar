using Scholar.Model;
using Scholar.Views;
using Scholar.Views.Admin;
using Scholar.Views.Applicant;

namespace Scholar;
public partial class AppShell : Shell
{
	public AppShell()
	{

		InitializeComponent();
       // Changedashboard();
        Routing.RegisterRoute(nameof(ApplyNow), typeof(ApplyNow));
        Routing.RegisterRoute(nameof(AddPersonBiodata), typeof(AddPersonBiodata));
        Routing.RegisterRoute(nameof(Signin), typeof(Signin));
        Routing.RegisterRoute(nameof(ApplicantDashboard), typeof(ApplicantDashboard));
        Routing.RegisterRoute(nameof(AdminDashboard), typeof(AdminDashboard));
        Routing.RegisterRoute(nameof(AddCountry), typeof(AddCountry));
        Routing.RegisterRoute(nameof(AddState), typeof(AddState));
    }
    private async void SignOut(object sender, EventArgs e)

        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
            Preferences.Remove(nameof(App.UserDetails));
            }
            Preferences.Default.Clear();

            await Shell.Current.GoToAsync(nameof(Signin));

    }

    
}
