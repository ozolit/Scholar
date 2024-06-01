using Scholar.ViewModel;

namespace Scholar.Views;

public partial class Home : ContentPage
{
	public Home(SigninViewModel signViewModel)
	{
		InitializeComponent();
		this.BindingContext = signViewModel;
	}

    private async void OpenApplyPage(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(ApplyNow));
    }
}