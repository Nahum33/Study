namespace React_App.AppCode.Interfaces
{
    /// <summary>
    /// The Command interface declares a method to execute a Command.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Perform the command.
        /// </summary>
        void Execute();
    }
}