using Scholar.Model;
using SQLite;

namespace Scholar;

public partial class App : Application
{
    public SQLiteAsyncConnection _DbConnection;
    public static Person UserDetails;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
	
}
