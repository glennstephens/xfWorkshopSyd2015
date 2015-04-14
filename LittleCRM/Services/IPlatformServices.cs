using System;

namespace LittleCRM
{
	public interface IPlatformServices
	{
		string GetDBStoragePath(string filename);
	}
}

