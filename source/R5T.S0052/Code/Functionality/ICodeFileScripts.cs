using System;
using System.Threading.Tasks;

using R5T.F0083;
using R5T.T0132;


namespace R5T.S0052
{
	[FunctionalityMarker]
	public partial interface ICodeFileScripts : IFunctionalityMarker
	{
		public async Task CreateDocumentation_ViaRazorComponent()
		{
			/// Inputs.
			var codeFilePath =
				CodeFilePaths.Instance.TempCSharp
				;
			var namespaceName =
				NamespaceNames.Instance.N0001
				;
			var projectDescription =
				ProjectDescriptions.Instance.Example
				;


			/// Run.
			await F0083.CodeFileGenerationOperations.Instance.CreateDocumentationFile(
				codeFilePath,
				namespaceName,
				projectDescription);

			F0033.NotepadPlusPlusOperator.Instance.Open(codeFilePath);
		}

		public void CreateDocumentation_ViaTextSubstitution()
        {
            /// Inputs.
            var codeFilePath =
                CodeFilePaths.Instance.TempCSharp
                ;
            var namespaceName =
                NamespaceNames.Instance.N0001
                ;
            var projectDescription =
                ProjectDescriptions.Instance.Example
                ;


            /// Run.
            F0053.CodeFileGenerator.Instance.CreateDocumentationFile(
                codeFilePath,
                namespaceName,
                projectDescription);

            F0033.NotepadPlusPlusOperator.Instance.Open(codeFilePath);
        }

        public async Task CreateStronglyTypedGuid()
        {
            /// Inputs.
            var codeFilePath =
                Z0021.CodeFilePaths.Instance.TempCSharp
                ;
            var name = "TestIdentity";
            var description = "A test identity strongly typed type.";
            var namespaceName = NamespaceNames.Instance.N0001;


            /// Run.
            await CodeFileGenerationOperations.Instance.CreateStronglyTypedGuid(
                codeFilePath,
                namespaceName,
                name,
                description);

            F0033.NotepadPlusPlusOperator.Instance.Open(codeFilePath);
        }

		public void CreateProgram_ViaTextSubstitution()
		{
			/// Inputs.
            var programFilePath = CodeFilePathOperator.Instance.ForTypeName(
                TypeNames.Instance.Program);


			/// Run.
			F0053.CodeFileGenerator.Instance.CreateProgramFile(
				programFilePath,
                NamespaceNames.Instance.N0001);

			F0033.NotepadPlusPlusOperator.Instance.Open(programFilePath);
		}

        public async Task CreateProgram_ViaRazorComponent()
        {
            /// Inputs.
            var namespaceName = NamespaceNames.Instance.N0001;

            var programFilePath = CodeFilePathOperator.Instance.ForTypeName(
                TypeNames.Instance.Program);


            /// Run.
            await CodeFileGenerationOperations.Instance.CreateProgramFile_Console(
                programFilePath,
                namespaceName);

            F0033.NotepadPlusPlusOperator.Instance.Open(programFilePath);
        }

        public async Task CreateProgramFile_ForWebServerForBlazorClient()
        {
            /// Inputs.
            var namespaceName = NamespaceNames.Instance.N0001;

            var programFilePath = CodeFilePathOperator.Instance.ForTypeName(
                TypeNames.Instance.Program);


            /// Run.
            await CodeFileGenerationOperations.Instance.CreateProgramFile_WebServerForBlazorClient(
                programFilePath,
                namespaceName);

            F0033.NotepadPlusPlusOperator.Instance.Open(programFilePath);
        }

        public async Task CreateLaunchSettings_WebServerForBlazorClient()
        {
            /// Inputs.
            var projectName =
                Z0019.ProjectNames.Instance.Example
                ;

            var outputJsonFilePath = Z0015.FilePaths.Instance.OutputJsonFilePath;


            /// Run.
            await CodeFileGenerationOperations.Instance.CreateLaunchSettings_WebServerForBlazorClient(
                outputJsonFilePath,
                projectName);

            F0033.NotepadPlusPlusOperator.Instance.Open(outputJsonFilePath);
        }
    }
}