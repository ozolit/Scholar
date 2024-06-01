using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Scholar.Model;
using Scholar.Views;
using Scholar.Views.Applicant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.ViewModel
{
    public partial class PersonViewModel: ObservableObject
    {
        [RelayCommand]
        public async Task AddPerson(Person person)
        {
            await AppShell.Current.GoToAsync(nameof(AddPersonBiodata));
        }


    }
}
