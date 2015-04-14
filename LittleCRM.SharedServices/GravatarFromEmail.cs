using System;
using System.Security.Cryptography;
using Xamarin.Forms;
using System.Text;

[assembly: Dependency(typeof(LittleCRM.SharedServices.GravatarFromEmail))]

namespace LittleCRM.SharedServices
{
	public class GravatarFromEmail : IImageGravatar
	{
		public string ImageUriFromEmail(string email)
		{
			var hash = MD5.Create();
			var data = hash.ComputeHash(Encoding.Default.GetBytes(email.Trim().ToLower()));
			var sb = new StringBuilder();

			for (int counter = 0; counter < data.Length; counter++)
				sb.Append(data[counter].ToString("x2"));

			return String.Format("https://www.gravatar.com/avatar/{0}", sb.ToString()); 
		}
	}
}

