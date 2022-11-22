using System;


namespace R5T.S0052
{
	public class TypeNames : ITypeNames
	{
		#region Infrastructure

	    public static ITypeNames Instance { get; } = new TypeNames();

	    private TypeNames()
	    {
        }

	    #endregion
	}
}