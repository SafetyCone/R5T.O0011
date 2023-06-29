using System;
using System.Threading.Tasks;

using R5T.L0040.T000;
using R5T.T0131;
using R5T.T0159;


namespace R5T.O0011.O001
{
    [ValuesMarker]
    public partial interface IProjectOperations : IValuesMarker
    {
        private static Internal.IProjectOperations Internal => O001.Internal.ProjectOperations.Instance;


        public Task In_New_SampleProjectContext(
            ITextOutput textOutput,
            Func<IProjectContext, Task> projectContextAction = default)
        {
            var projectContext = Internal.PrepareAndGetContext(textOutput);

            return Instances.ActionOperator.Run(
                projectContextAction,
                projectContext);
        }

        public void In_New_SampleProjectContext(
            ITextOutput textOutput,
            Action<IProjectContext> projectContextAction = default)
        {
            var projectContext = Internal.PrepareAndGetContext(textOutput);

            Instances.ActionOperator.Run(
                projectContextAction,
                projectContext);
        }
    }
}
