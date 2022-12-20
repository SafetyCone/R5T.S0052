using System;
using System.Runtime;
using System.Threading.Tasks;

using R5T.F0083;
using R5T.L0026;
using R5T.T0132;


namespace R5T.S0052
{
	[FunctionalityMarker]
	public partial interface ICodeFileScripts : IFunctionalityMarker
	{
        public async Task CreateWinForm()
        {
            /// Inputs.
            bool clearFilesDuringConstruction = true;
            var winFormName =
                TypeNames.Instance.ExampleWinForm
                ;
            var projectFilePath =
                ExampleProjectFilePaths.Instance.Example
                ;


            /// Run
            var winFormContext = F0089.WinFormContextOperations.Instance.GetWinFormContext(
                projectFilePath,
                winFormName);

            if (clearFilesDuringConstruction)
            {
                F0000.FileSystemOperator.Instance.DeleteFile_OkIfNotExists(winFormContext.CodeFilePath);
                F0000.FileSystemOperator.Instance.DeleteFile_OkIfNotExists(winFormContext.DesignerFilePath);
            }

            await F0094.CodeFileOperations.Instance.CreateWinForm(winFormContext);

            // Show outputps.
            F0033.NotepadPlusPlusOperator.Instance.Open(
                winFormContext.CodeFilePath,
                winFormContext.DesignerFilePath,
                winFormContext.ResxFilePath);
        }

        public async Task CreateInstance()
        {
            /// Inputs.
            var projectFilePath =
                ExampleProjectFilePaths.Instance.Example
                ;
            var instanceType =
                InstanceTypes.Instance.Functionality
                ;
            var instanceTypeNameStems = new[]
            {
                "ExampleInstance"
            };


            /// Run.
            foreach (var instanceTypeNameStem in instanceTypeNameStems)
            {
                var instanceTypeContext = F0089.InstanceTypeContextOperations.Instance.GetInstanceTypeContext(
                    projectFilePath,
                    instanceTypeNameStem,
                    instanceType);

                await CodeFileGenerationOperations.Instance.CreateInstanceInterfaceCodeFile(
                    instanceTypeContext.InterfaceCodeFilePath,
                    instanceTypeContext.NamespaceName,
                    instanceTypeContext.InterfaceTypeName,
                    instanceTypeContext.MarkerAttributeTypeName,
                    instanceTypeContext.MarkerInterfaceTypeName,
                    new[]
                    {
                        instanceTypeContext.MarkerAttributeNamespaceName,
                        instanceTypeContext.MarkerInterfaceNamespaceName,
                    });

                await CodeFileGenerationOperations.Instance.CreateInstanceClassCodeFile(
                    instanceTypeContext.ClassCodeFilePath,
                    instanceTypeContext.NamespaceName,
                    instanceTypeContext.ClassTypeName,
                    instanceTypeContext.InterfaceTypeName);

                F0033.NotepadPlusPlusOperator.Instance.Open(
                    instanceTypeContext.ClassCodeFilePath,
                    instanceTypeContext.InterfaceCodeFilePath);
            }
        }

        public async Task CreateRazorComponent()
        {
            /// Inputs.
            var componentTypeName =
                TypeNames.Instance.ExampleComponent
                ;
            var projectFilePath =
                ExampleProjectFilePaths.Instance.Example
                ;


            /// Run.
            var razorComponentContext = F0089.CodeFileContextOperations.Instance.GetRazorComponentContext(
                projectFilePath,
                componentTypeName);

            await CodeFileGenerationOperations.Instance.CreateRazorComponentMarkupFile(
                razorComponentContext.RazorFilePath,
                razorComponentContext.NamespaceName);

            await CodeFileGenerationOperations.Instance.CreateRazorComponentCodeBehindFile(
                razorComponentContext.CodeBehindFilePath,
                razorComponentContext.NamespaceName,
                razorComponentContext.Name);

            // Show outputs.
            F0033.NotepadPlusPlusOperator.Instance.Open(
                razorComponentContext.RazorFilePath,
                razorComponentContext.CodeBehindFilePath);
        }

        public async Task CreateClass()
        {
            /// Inputs.
            var typeName =
                TypeNames.Instance.Class1
                ;
            var codeFilePath =
                CodeFilePaths.Instance.TempCSharp
                ;
            var namespaceName =
                NamespaceNames.Instance.N0001
                ;


            /// Run.
            await CodeFileGenerationOperations.Instance.CreateClassCSharpFile(
                codeFilePath,
                namespaceName,
                typeName);

            F0033.NotepadPlusPlusOperator.Instance.Open(codeFilePath);
        }

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
			await CodeFileGenerationOperations.Instance.CreateDocumentationFile(
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