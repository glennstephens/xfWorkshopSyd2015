using System;

namespace LittleCRM
{
	public interface IImageGravatar
	{
		string ImageUriFromEmail(string email);
	}
}

