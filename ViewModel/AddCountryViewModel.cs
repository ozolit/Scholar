using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Scholar.Model;
using Scholar.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.ViewModel
{
    public partial class AddCountryViewModel: ObservableObject
    {
        private readonly IPersonServices personServices;
        public AddCountryViewModel(IPersonServices _personServices)
        {
            personServices = _personServices;
            CountryDetails = new Country();

        }
        [ObservableProperty]
        public Country _CountryDetails;


        [RelayCommand]
        public async Task AddCountryToTable()
        {
            if (CountryDetails != null)
            {
                var responseCheck = await personServices.CheckExistingCountry(CountryDetails);
                if(responseCheck == null)
                {
                    var response = await personServices.AddCountry(CountryDetails);
                    if (response > 0)
                    {
                        CountryDetails.Name = string.Empty;
                        await Shell.Current.DisplayAlert("Record Addedd", "Country Details Successfully Added", "Ok");
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Not Addedd", "Somthing went wrong during submission", "Ok");


                    }
                }
                else
                {
                    await Shell.Current.DisplayAlert("Data Exists", "The Country Already Addedd", "Ok");
                }

            }
            else
            {
                await Shell.Current.DisplayAlert("empty Reacord", "Input Fields must contain Data", "Ok");

            }

        }

    }
}
