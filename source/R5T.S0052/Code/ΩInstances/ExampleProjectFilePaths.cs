using System;


namespace R5T.S0052
{
	public class ExampleProjectFilePaths : IExampleProjectFilePaths
	{
		#region Infrastructure

	    public static IExampleProjectFilePaths Instance { get; } = new ExampleProjectFilePaths();

	    private ExampleProjectFilePaths()
	    {
        }

	    #endregion
	}
}