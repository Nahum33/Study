using React_App.AppCode.Commands.Interfaces;

namespace React_App.AppCode.Commands.Concretes
{
    /// <summary>
    /// The GetSearchTermParameterCommand class implements the ICommand interface and defines a binding between a Receiver object and an action.
    /// </summary>
    public class GetSearchTermParameterCommand : ICommand<KeyValuePair<string, string>>
    {
        private const string Key = "title";
        private readonly string _searchTerm;

        /// <summary>
        /// Initializes a new instance of the GetSearchTermParameterCommand class.
        /// </summary>
        /// <param name="searchTerm"> search term value string</param>
        public GetSearchTermParameterCommand(string? searchTerm)
        {
            _searchTerm = !string.IsNullOrEmpty(searchTerm) ? searchTerm : string.Empty;
        }

        /// <inheritdoc/>
        public KeyValuePair<string, string> Execute()
        {
            return new KeyValuePair<string, string>(Key, _searchTerm);
        }
    }
}