using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(LittleCRM.iOS.iOSPlatformServices))]

namespace LittleCRM.iOS
{
	public class iOSPlatformServices : IPlatformServices
	{
		public string GetDBStoragePath (string filename)
		{
			return 
				Path.Combine (
				Environment.GetFolderPath (Environment.SpecialFolder.Personal),
				"..", 
				"Library", 
				filename);
		}
	}
}

