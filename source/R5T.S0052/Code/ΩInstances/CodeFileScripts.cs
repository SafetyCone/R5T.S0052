using System;


namespace R5T.S0052
{
	public class CodeFileScripts : ICodeFileScripts
	{
		#region Infrastructure

	    public static ICodeFileScripts Instance { get; } = new CodeFileScripts();

	    private CodeFileScripts()
	    {
        }

	    #endregion
	}
}