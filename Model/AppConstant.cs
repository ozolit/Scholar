using Scholar.Controls;
using Scholar.Views.Admin;
using Scholar.Views.Applicant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.Model
{
    public class AppConstant
    {
        public async static Task AddFlyoutMenuDetals()
        {
            Shell.Current.FlyoutHeader = new FlyoutHeader();

            var ApplicantInfo = Shell.Current.Items.Where(a => a.Route == nameof(ApplicantDashboard)).FirstOrDefault();
            if (ApplicantInfo != null) Shell.Current.Items.Remove(ApplicantInfo);

            var AdminInfo = Shell.Current.Items.Where(a => a.Route == nameof(AdminDashboard)).FirstOrDefault();
            if (AdminInfo != null) Shell.Current.Items.Remove(AdminInfo);


            if (App.UserDetails.PersonTypeId == 1)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Admin Dashboard",
                    Route = "AdminDashboard",
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                        {
                        new ShellContent
                            {

                                Title ="Add Country",
                                ContentTemplate = new DataTemplate(typeof(AddCountry)),

                            },
                        new ShellContent
                            {


                                Title ="Add State",
                                ContentTemplate = new DataTemplate(typeof(AddState)),

                            },

                        }

                };

                if (!Shell.Current.Items.Contains(flyoutItem))
                {
                    Shell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync(nameof(AdminDashboard));
                }



            }
            if (App.UserDetails.PersonTypeId == 2)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Applicant Dashboard",
                    Route = "ApplicantDashboard",
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                        {
                        new ShellContent
                            {

                                Title ="Applicant BioData",
                                ContentTemplate = new DataTemplate(typeof(AddPersonBiodata)),

                            },
                        new ShellContent
                            {


                                Title ="Academic Details",
                                ContentTemplate = new DataTemplate(typeof(AcademicDetails)),

                            },

                        }

                };
                if (!Shell.Current.Items.Contains(flyoutItem))
                {
                    Shell.Current.Items.Add(flyoutItem);
                    await Shell.Current.GoToAsync(nameof(ApplicantDashboard));

                }



            }
        }
    }
}
