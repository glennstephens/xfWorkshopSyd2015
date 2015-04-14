using System;
using SQLite;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LittleCRM
{
	public class DataServices : SQLiteAsyncConnection
	{
		public ObservableCollection<Customer> Data = new ObservableCollection<Customer>();

		public DataServices (string path) : base(path, true)
		{
			this.CreateTableAsync<Customer> ().Wait ();
		}

		public async Task<List<Customer>> GetCustomers()
		{
			return await Table<Customer> ().ToListAsync ();
		}

		public async Task<int> UpdateCustomer(Customer customer)
		{
			if (Data != null && !Data.Contains (customer))
					Data.Add (customer);
			
			if (customer.ID == 0)
				return await InsertAsync (customer);
			else
				return await UpdateAsync (customer);
		}

		public async Task<int> RemoveCustomer(Customer customer)
		{
			var result = await DeleteAsync (customer);
			if (Data != null)
				Data.Remove (customer);
			return result;
		}
	}
}

