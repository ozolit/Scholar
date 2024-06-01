using Scholar.Model;
using Scholar.Services;
using Scholar.ViewModel;

namespace Scholar.Views.Admin;

public partial class AddCountry : ContentPage
{
	private readonly IPersonServices _PersonServices;

	public AddCountry(AddCountryViewModel addCountryViewModel, IPersonServices PersonServices)
	{
		InitializeComponent();
        _PersonServices = PersonServices;
		BindingContext = addCountryViewModel;
    }

	private async void AddCountryButton(Country country, EventArgs e)
	{
		
		//var CountryName = country.Text;
		if (country != null)
		{
			//check if the country Name Exists
			var CheckCountryNameExistence = await _PersonServices.CheckExistingCountry(country);
			if (CheckCountryNameExistence == null)
			{
				var response = await _PersonServices.AddCountry(country);
				if (response != null)
				{
					await Shell.Current.DisplayAlert("Record Addedd", "Country Details Successfully Added", "Ok");

				}
				else
				{
					await Shell.Current.DisplayAlert("Record  not Addedd", "Error Occurred during insertion", "Ok");

				}
			}
			else
			{
				await Shell.Current.DisplayAlert("Record Exists", "Country Already Exists", "Ok");

			}
		}
		else
		{
			await Shell.Current.DisplayAlert("Wait", "Field can be empty", "Ok");

		}


	}
}