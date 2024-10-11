namespace React_App.AppCode.Commands.Interfaces
{
    /// <summary>
    /// The Command interface declares a method to execute a Command.
    /// </summary>
    public interface ICommand<out T>
    {
        /// <summary>
        /// Perform the command.
        /// </summary>
        T Execute();
    }
}