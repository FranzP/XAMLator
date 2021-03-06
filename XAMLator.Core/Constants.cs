﻿using System;
namespace XAMLator
{
#if XAMLATOR_BUILD_TASK
	public static class BuildConstants
#else
	public static class Constants
#endif
	{
		public const string DEFAULT_HOST = "127.0.0.1";

		public const int DEFAULT_PORT = 8488;

		public const string XAMLATOR_ASSEMBLY = "XAMLator.Server.dll";

		public const string IDE_IP_RESOURCE_NAME = "IdeIP";

		public const string ROOT_REPLACEMENT = "@ROOT@";
	}
}
