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
    public partial class AddPersonViewModel:ObservableObject
    {
        private readonly IPersonServices _personServices;
        public AddPersonViewModel(IPersonServices personServices)
        {
            _personServices = personServices;
            PersonDetails = new Person();
        }

        

        [ObservableProperty]
        public Person _PersonDetails;


        [RelayCommand]
        public async Task AddPersonToTable()
        {
            if (PersonDetails != null)
            {
                var response = await _personServices.AddPerson(PersonDetails);
                if (response > 0)
                {
                    await Shell.Current.DisplayAlert("Record Addedd", "Employee Details Successfully Added", "Ok");
                }
                else
                {
                    await Shell.Current.DisplayAlert("Not Addedd", "Somthing went wrong during submission", "Ok");


                }
            }
            else
            {
                await Shell.Current.DisplayAlert("empty Reacord", "Input Fields must contain Data", "Ok");

            }

        }
    }
}
