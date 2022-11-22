using System;


namespace R5T.S0052
{
	public class CodeFilePaths : ICodeFilePaths
	{
		#region Infrastructure

	    public static ICodeFilePaths Instance { get; } = new CodeFilePaths();

	    private CodeFilePaths()
	    {
        }

	    #endregion
	}
}