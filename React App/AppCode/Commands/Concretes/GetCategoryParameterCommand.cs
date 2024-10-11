using React_App.AppCode.Commands.Interfaces;

namespace React_App.AppCode.Commands.Concretes
{
    /// <summary>
    /// The GetCategoryParameterCommand class implements the ICommand interface and defines a binding between a Receiver object and an action.
    /// </summary>
    public class GetCategoryParameterCommand : ICommand<KeyValuePair<string, string>>
    {
        private const string Key = "title";
        private readonly string _category;

        /// <summary>
        /// Initializes a new instance of the GetCategoryParameterCommand class.
        /// </summary>
        /// <param name="category"> category value string.</param>
        public GetCategoryParameterCommand(string? category)
        {
            _category = !string.IsNullOrEmpty(category) ? category : string.Empty;
        }

        /// <inheritdoc/>
        public KeyValuePair<string, string> Execute()
        {
            return new KeyValuePair<string, string>(Key, _category);
        }
    }
}