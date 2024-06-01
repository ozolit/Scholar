namespace Scholar.Controls;

public partial class FlyoutHeader : StackLayout
{
	public FlyoutHeader()
	{
		InitializeComponent();
		if (App.UserDetails !=null)
		{
			lblUserName.Text = App.UserDetails.FirstName;
			lblUserEmail.Text = App.UserDetails.Email;

        }
	}

	
}