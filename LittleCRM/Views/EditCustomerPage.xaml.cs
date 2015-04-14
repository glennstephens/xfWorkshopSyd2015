using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LittleCRM
{
	public partial class EditCustomerPage : ContentPage
	{
		Customer customer;
		bool HasDeleted = false;

		public EditCustomerPage (Customer customer)
		{
			this.customer = customer;
			this.BindingContext = customer;

			InitializeComponent ();

			SaveButton.Clicked += async (object sender, EventArgs e) => {
				await App.db.UpdateCustomer(customer);
				await Navigation.PopAsync();
			};

			DeleteButton.Clicked += async (object sender, EventArgs e) => {
				await App.db.RemoveCustomer(customer);
				HasDeleted = true;
				await Navigation.PopAsync();
			};
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();

			if (customer != null && !HasDeleted)
				App.db.UpdateCustomer (customer);
		}
	}
}

