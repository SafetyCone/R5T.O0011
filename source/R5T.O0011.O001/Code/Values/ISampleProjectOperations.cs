using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.L0040.T000;
using R5T.T0131;
using R5T.T0159;


namespace R5T.O0011.O001
{
    [ValuesMarker]
    public partial interface ISampleProjectOperations : IValuesMarker
    {
        private static Internal.ISampleProjectOperations Internal => O001.Internal.SampleProjectOperations.Instance;


        public Task In_New_SampleProjectContext(
            ITextOutput textOutput,
            Func<IProjectContext, Task> projectContextAction = default)
        {
            var projectContext = Internal.PrepareAndGetContext(textOutput);

            return Instances.ActionOperator.Run(
                projectContextAction,
                projectContext);
        }

        public Task In_New_SampleProjectContext(
            ITextOutput textOutput,
            IEnumerable<Func<IProjectContext, Task>> projectContextActions = default)
        {
            var projectContext = Internal.PrepareAndGetContext(textOutput);

            return Instances.ActionOperator.Run(
                projectContext,
                projectContextActions);
        }

        public Task In_New_SampleProjectContext(
            ITextOutput textOutput,
            params Func<IProjectContext, Task>[] projectContextActions)
        {
            return this.In_New_SampleProjectContext(
                textOutput,
                projectContextActions.AsEnumerable());
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
