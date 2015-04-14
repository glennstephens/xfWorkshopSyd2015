using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace LittleCRM
{
	public partial class CustomersListPage : ContentPage
	{
		public CustomersListPage ()
		{
			InitializeComponent ();
			allCustomers.ItemsSource = App.db.Data;

			allCustomers.ItemTapped += 
				(object sender, ItemTappedEventArgs e) => NavigateToCustomerAsync (e.Item as Customer);

			addCustomer.Clicked += (object sender, EventArgs e) => {
				Customer c = new Customer();
				App.db.Data.Add(c);

				NavigateToCustomerAsync(c);
			};

			LoadExistingCustomersAsync ();
		}

		async Task LoadExistingCustomersAsync ()
		{
			var items = await App.db.GetCustomers ();
			foreach (var item in items)
				App.db.Data.Add (item);
		}

		async Task NavigateToCustomerAsync(Customer c)
		{
			var page = new EditCustomerPage(c);
			await Navigation.PushAsync(page);
			allCustomers.SelectedItem = null;
		}
	}
}

