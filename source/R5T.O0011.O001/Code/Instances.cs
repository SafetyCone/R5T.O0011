using System;


namespace R5T.O0011.O001
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static Z0046.IDirectoryPaths DirectoryPaths => Z0046.DirectoryPaths.Instance;
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0129.IProjectPathsOperator ProjectPathsOperator => F0129.ProjectPathsOperator.Instance;
        public static Z0046.IValues Values => Z0046.Values.Instance;
    }
}