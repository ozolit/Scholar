using Microsoft.Extensions.Logging;
using Scholar.Services;
using Scholar.ViewModel;
using Scholar.Views;
using Scholar.Views.Admin;
using Scholar.Views.Applicant;

namespace Scholar;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


//#if DEBUG
//        builder.Logging.AddDebug();
//#endif

        //Services
        builder.Services.AddSingleton<IPersonServices, PersonServices>();



        //Views
        builder.Services.AddSingleton<Home>();
        builder.Services.AddTransient<About>();
        builder.Services.AddTransient<ApplyNow>();
        builder.Services.AddTransient<AddPersonBiodata>();
        builder.Services.AddTransient<Eligibility>();
        builder.Services.AddTransient<Requirements>();
        builder.Services.AddTransient<Signin>();
        builder.Services.AddTransient<ApplicantDashboard>();
        builder.Services.AddTransient<AdminDashboard>();
        builder.Services.AddTransient<AddCountry>();
        builder.Services.AddTransient<AddState>();




        //View Model
        builder.Services.AddTransient<PersonViewModel>();
        builder.Services.AddTransient<AddPersonViewModel>();
        builder.Services.AddTransient<SigninViewModel>();
        builder.Services.AddTransient<UserDashboardViewModel>();
        builder.Services.AddTransient<AddCountryViewModel>();

        return builder.Build();
	}
}
