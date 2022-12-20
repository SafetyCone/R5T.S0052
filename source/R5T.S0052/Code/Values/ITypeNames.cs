using System;

using R5T.T0131;


namespace R5T.S0052
{
	[ValuesMarker]
	public partial interface ITypeNames : IValuesMarker
	{
		public string ExampleComponent => "ExampleComponent";
		public string ExampleWinForm => "ExampleWinForm";
        public string Class1 => "Class1";
        public string Program => "Program";
	}
}