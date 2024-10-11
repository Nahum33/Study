using React_App.AppCode.Commands.Concretes;
using React_App.Services;
using System.Web;

namespace React_App.Extensions
{
    /// <summary>
    /// Extension class to extend Search Parameters.
    /// </summary>
    public static class SearchParametersExtensions
    {
        /// <summary>
        /// Method to get QueryString Parameters Based on Object to Map parameters
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static string GetQueryStringParameters(this IList<KeyValuePair<string, string>> parameters)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);

            foreach (var parameter in parameters)
            {
                if (!string.IsNullOrEmpty(parameter.Value))
                {
                    query[parameter.Key] = parameter.Value;
                }
            }

            return query.ToString() ?? string.Empty;
        }
    }
}
