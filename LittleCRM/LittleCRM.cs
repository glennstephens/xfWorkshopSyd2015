using System;
using SQLite;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace LittleCRM
{
	public class App : Application
	{
		public static DataServices db;

		public App ()
		{
			// Get it from the in-memory sample
			// Get the data from the database
			var platform = DependencyService.Get<IPlatformServices> ();
			db = new DataServices (platform.GetDBStoragePath ("LittleCRM.db3"));

			// The root page of your application
			MainPage = new NavigationPage(new CustomersListPage());

			db.Data = new ObservableCollection<Customer> (CustomerData.Customers);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

