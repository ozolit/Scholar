using Scholar.Services;
using Scholar.ViewModel;
namespace Scholar.Views;

public partial class ApplyNow : ContentPage
{
    public ApplyNow()
    {
    }

    public ApplyNow(AddPersonViewModel PersonDetails)
	{
		InitializeComponent();
		BindingContext = PersonDetails;

	}
}