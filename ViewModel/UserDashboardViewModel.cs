using GalaSoft.MvvmLight;
using Scholar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.ViewModel
{
    public partial class UserDashboardViewModel: ViewModelBase

    {
        private readonly IPersonServices _personServices;
        public UserDashboardViewModel(int userId,IPersonServices personServices)
        {
            _personServices = personServices;
            LoadData(userId);
        }


        private async void LoadData(int userId)
        {
            var userDetails = await _personServices.GetOneUserById(userId);

            if(userDetails != null)
            {
                Console.WriteLine($"FirstName :{userDetails.FirstName}");
            }

            // Fetch user-specific data using the userId
        }

    }
}
