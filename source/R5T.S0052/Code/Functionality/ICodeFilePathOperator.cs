using System;

using R5T.T0132;


namespace R5T.S0052
{
	[FunctionalityMarker]
	public partial interface ICodeFilePathOperator : IFunctionalityMarker
	{
		public string ForTypeName(string typeName)
		{
			var csharpFileName = F0053.CodeFileNameOperator.Instance.GetCSharpCodeFileName_ForTypeName(typeName);

			var csharpFilePath = F0002.PathOperator.Instance.GetFilePath(
				DirectoryPaths.Instance.TemporaryCodeFiles,
				csharpFileName);

			return csharpFilePath;
		}
	}
}