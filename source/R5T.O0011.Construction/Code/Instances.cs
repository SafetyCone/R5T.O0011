using System;


namespace R5T.O0011.Construction
{
    public static class Instances
    {
        public static F0000.IActionOperations ActionOperations => F0000.ActionOperations.Instance;
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static L0040.IProjectContextOperations ProjectContextOperations => L0040.ProjectContextOperations.Instance;
        public static L0033.IProjectFileContextOperations ProjectFileContextOperations => L0033.ProjectFileContextOperations.Instance;
        public static O001.IProjectOperations ProjectOperations => O001.ProjectOperations.Instance;
        public static IValues Values => Construction.Values.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
    }
}