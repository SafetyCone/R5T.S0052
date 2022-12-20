using System;
using System.Threading.Tasks;


namespace R5T.S0052
{
    class Program
    {
        static async Task Main()
        {
            //CodeFileScripts.Instance.CreateProgram_ViaTextSubstitution();
            //await CodeFileScripts.Instance.CreateProgram_ViaRazorComponent();
            //await CodeFileScripts.Instance.CreateProgramFile_ForWebServerForBlazorClient();

            //await CodeFileScripts.Instance.CreateClass();
            //await CodeFileScripts.Instance.CreateStronglyTypedGuid();
            //await CodeFileScripts.Instance.CreateRazorComponent();
            //await CodeFileScripts.Instance.CreateInstance();
            await CodeFileScripts.Instance.CreateWinForm();

            //CodeFileScripts.Instance.CreateDocumentation_ViaTextSubstitution();
            //await CodeFileScripts.Instance.CreateDocumentation_ViaRazorComponent();

            //await CodeFileScripts.Instance.CreateLaunchSettings_WebServerForBlazorClient();
		}
    }
}