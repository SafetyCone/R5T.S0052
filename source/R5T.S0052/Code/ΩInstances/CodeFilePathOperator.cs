using System;


namespace R5T.S0052
{
	public class CodeFilePathOperator : ICodeFilePathOperator
	{
		#region Infrastructure

	    public static ICodeFilePathOperator Instance { get; } = new CodeFilePathOperator();

	    private CodeFilePathOperator()
	    {
        }

	    #endregion
	}
}