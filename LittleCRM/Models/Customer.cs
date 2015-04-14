using System;
using System.ComponentModel;
using Xamarin.Forms;
using SQLite;

namespace LittleCRM
{
	public class Customer : BaseDataItem
	{
		private int _ID;

		[PrimaryKey, AutoIncrement]
		public int ID {
			get { return _ID; }
			set {
				if (_ID != value) {
					_ID = value;
					DoPropertyChanged ("ID");
				}
			}
		}

		private string _Name;

		public string Name {
			get { return _Name; }
			set {
				if (_Name != value) {
					_Name = value;
					DoPropertyChanged ("Name");
				}
			}
		}

		private string _Email;

		public string Email {
			get { return _Email; }
			set {
				if (_Email != value) {
					_Email = value;
					DoPropertyChanged ("Email");
					DoPropertyChanged ("HeadshotUri");
				}
			}
		}

		private string _PhoneNumber;

		public string PhoneNumber {
			get { return _PhoneNumber; }
			set {
				if (_PhoneNumber != value) {
					_PhoneNumber = value;
					DoPropertyChanged ("PhoneNumber");
				}
			}
		}

		[Ignore]
		public string HeadshotUri {
			get {
				var imgsvc = DependencyService.Get<IImageGravatar> ();
				if (imgsvc == null)
					return null;

				if (String.IsNullOrEmpty (Email))
					return null;
				
				return imgsvc.ImageUriFromEmail (Email);
			}
		}
	}

	public class CustomerData
	{
		public static Customer[] Customers = new Customer[] {
			new Customer() {
				ID = 1,
				Name = "Glenn Stephens",
				Email = "glennthomasstephens@gmail.com",
			},

			new Customer() {
				ID = 1,
				Name = "Glenn Stephens",
				Email = "glenn.stephens@xamarin.com",
			},
		};
	}
}

