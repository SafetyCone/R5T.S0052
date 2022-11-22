using System;

using R5T.T0131;


namespace R5T.S0052
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker
	{
		public string TemporaryCodeFiles => @"C:\Temp\Code Files\";
	}
}