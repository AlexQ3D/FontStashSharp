﻿using FontStashSharp.Interfaces;

namespace FontStashSharp
{
	public class StbTrueTypeSharpFontLoader : IFontLoader
	{
		public static readonly StbTrueTypeSharpFontLoader Instance = new StbTrueTypeSharpFontLoader();

		private StbTrueTypeSharpFontLoader()
		{
		}

		public IFontSource Load(byte[] data, FontSystemSettings settings)
		{
			return StbTrueTypeSharpFontSource.FromMemory(data, settings);
		}
	}
}
