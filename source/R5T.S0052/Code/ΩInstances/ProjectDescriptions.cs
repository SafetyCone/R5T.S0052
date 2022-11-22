using System;


namespace R5T.S0052
{
	public class ProjectDescriptions : IProjectDescriptions
	{
		#region Infrastructure

	    public static IProjectDescriptions Instance { get; } = new ProjectDescriptions();

	    private ProjectDescriptions()
	    {
        }

	    #endregion
	}
}