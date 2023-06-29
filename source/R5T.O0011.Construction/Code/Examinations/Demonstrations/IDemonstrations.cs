using System;
using System.Threading.Tasks;

using R5T.L0038;
using R5T.T0141;


namespace R5T.O0011.Construction
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public async Task In_New_SampleProjectContext()
        {
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.ProjectOperations.In_New_SampleProjectContext(
                    applicationContext.TextOutput,
                    async projectContext =>
                    {
                        await Instances.ProjectContextOperations.Create_New_Project(
                            Instances.ActionOperations.Combine_Asynchronously(
                                Instances.ProjectFileContextOperations.Setup_ProjectFile_WithLibraryBaseOperations()
                            ),
                            Instances.ActionOperations.DoNothing,
                            Instances.ActionOperations.DoNothing
                            )
                            (projectContext);

                        Instances.VisualStudioOperator.Open_ProjectFile(
                            projectContext.ProjectFilePath.Value);
                    });
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath,
                logFilePath);
        }
    }
}
