using System;


namespace R5T.O0011.O001.Internal
{
    public class ProjectOperations : IProjectOperations
    {
        #region Infrastructure

        public static IProjectOperations Instance { get; } = new ProjectOperations();


        private ProjectOperations()
        {
        }

        #endregion
    }
}
