using System;
using System.ComponentModel;

namespace LittleCRM
{
	public class BaseDataItem : INotifyPropertyChanged
	{
		public BaseDataItem ()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		public void DoPropertyChanged(string name)
		{
			PropertyChanged (this, new PropertyChangedEventArgs (name));
		}
	}
}

