using System;

using R5T.T0131;


namespace R5T.S0052
{
	[DraftValuesMarker]
	public partial interface IExampleProjectFilePaths : IDraftValuesMarker
	{
		public string Example => @"C:\Temp\Projects\Example\Example.csproj";
	}
}