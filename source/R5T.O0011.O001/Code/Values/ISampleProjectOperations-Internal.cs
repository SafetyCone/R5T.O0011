using System;

using R5T.L0040.T000;
using R5T.T0131;
using R5T.T0159;


namespace R5T.O0011.O001.Internal
{
    [ValuesMarker]
    public partial interface ISampleProjectOperations : IValuesMarker
    {
        public ProjectContext PrepareAndGetContext(
            ITextOutput textOutput)
        {
            var projectName = Instances.Values.Sample_ProjectName;
            var projectDirectoryParentDirectoryPath = Instances.DirectoryPaths.Sample_ProjectsDirectoryPath;

            var projectDirectoryPath = Instances.ProjectPathsOperator.Get_ProjectDirectoryPath(
                projectDirectoryParentDirectoryPath,
                projectName);

            // If the project directory exists, delete it.
            Instances.FileSystemOperator.DeleteDirectory_Idempotent(
                projectDirectoryPath.Value);

            var projectFilePath = Instances.ProjectPathsOperator.Get_ProjectFilePath(
                projectDirectoryParentDirectoryPath,
                projectName);

            // Now create and return the context.
            var projectContext = new ProjectContext
            {
                ProjectName = projectName,
                ProjectFilePath = projectFilePath,
                TextOutput = textOutput,
            };

            return projectContext;
        }
    }
}
