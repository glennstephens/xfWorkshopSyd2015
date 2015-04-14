using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(LittleCRM.Droid.DroidPlatformServices))]

namespace LittleCRM.Droid
{
	public class DroidPlatformServices : IPlatformServices
	{
		public string GetDBStoragePath (string filename)
		{
			return Path.Combine (
				Environment.GetFolderPath (Environment.SpecialFolder.Personal),
				filename);
		}
	}
}

