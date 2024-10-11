using React_App.AppCode.Commands.Interfaces;
using React_App.AppCode.Commands.Models;

namespace React_App.AppCode.Commands.Concretes
{
    /// <summary>
    /// The GetParametersCommand class implements the ICommand interface and defines a binding between a Receiver object and an action.
    /// </summary>
    public class GetSearchParametersCommand : ICommand<IList<KeyValuePair<string, string>>>
    {
        private readonly IList<KeyValuePair<string, string>> _parameters;
        /// <summary>
        /// Initializes a new instance of the GetParametersCommand class.
        /// </summary>
        /// <param name="searchCommand"> search command object</param>
        public GetSearchParametersCommand(SearchCommand searchCommand)
        {
            var searchTermParameter = new GetSearchTermParameterCommand(searchCommand.SearchTerm).Execute();
            var categoryParameter = new GetCategoryParameterCommand(searchCommand.Category).Execute();
            _parameters = new List<KeyValuePair<string, string>>() { searchTermParameter, categoryParameter };
        }

        /// <inheritdoc/>
        public IList<KeyValuePair<string, string>> Execute()
        {
            return _parameters;
        }
    }
}