using System;


namespace R5T.O0011.O001.Internal
{
    public class SampleProjectOperations : ISampleProjectOperations
    {
        #region Infrastructure

        public static ISampleProjectOperations Instance { get; } = new SampleProjectOperations();


        private SampleProjectOperations()
        {
        }

        #endregion
    }
}
