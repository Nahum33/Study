using React_App.Models;

namespace React_App.Services
{
    public interface IUserService
    {
        Task<User?> GetUserByIdentifier(string? identifier);
    }
}
