using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0040.T000;
using R5T.T0131;
using R5T.T0172;
using R5T.T0187;
using R5T.T0198;


namespace R5T.O0011
{
    /// <summary>
    /// Generation project context operations.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectContextOperations : IValuesMarker
    {
        public Func<IProjectContext, Task> Create_WebServerForBlazorClient(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            IProjectFilePath clientProjectFilePath,
            Func<IProjectFilePath, Task> projectFilePathHandler)
        {
            return Instances.ProjectContextOperations_L0040.Create_New_Project(
                Instances.ProjectFileContextOperations.Setup_WebServerForBlazorClientProjectFile(
                    projectDescription,
                    repositoryUrl,
                    clientProjectFilePath
                ),
                Instances.ProjectContextOperations_L0040.Setup_WebServerForBlazorClient(
                    projectDescription
                ),
                projectFilePathHandler
            );
        }

        /// <summary>
        /// Creates a console project file.
        /// </summary>
        public Func<IProjectContext, Task> Create_ConsoleProject(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            Func<IProjectFilePath, Task> projectFilePathHandler)
        {
            return Instances.ProjectContextOperations_L0040.Create_New_Project(
                Instances.ProjectFileContextOperations.Setup_ConsoleProjectFile(
                    projectDescription,
                    repositoryUrl
                ),
                Instances.ProjectContextOperations_L0040.Setup_ConsoleProject(
                    projectDescription
                ),
                projectFilePathHandler
            );
        }

        /// <summary>
        /// Creates a library project file.
        /// </summary>
        public Func<IProjectContext, Task> Create_LibraryProject(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            Func<IProjectFilePath, Task> projectFilePathHandler)
        {
            return Instances.ProjectContextOperations_L0040.Create_New_Project(
                Instances.ProjectFileContextOperations.Setup_LibraryProjectFile(
                    projectDescription,
                    repositoryUrl
                ),
                Instances.ProjectContextOperations_L0040.Setup_LibraryProject(
                    projectDescription
                ),
                projectFilePathHandler
            );
        }
    }
}
