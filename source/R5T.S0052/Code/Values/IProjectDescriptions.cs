using System;

using R5T.T0131;


namespace R5T.S0052
{
	[ValuesMarker]
	public partial interface IProjectDescriptions : IValuesMarker
	{
		public string Example => "Example description for project.";
	}
}