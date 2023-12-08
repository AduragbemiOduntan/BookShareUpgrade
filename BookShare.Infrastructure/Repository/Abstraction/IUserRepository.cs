using BookShare.Domain.Model;

namespace BookShare.Infrastructure.Repository.Abstraction
{
    public interface IUserRepository 
    {
        void CreateUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        Task<User> GetByEmailAsync(string email, bool trackChanges); // GetUserByEmailAsync
        Task<User> GetByIdAsync(string id);  // GetuserByIdAsync
        Task<User> GetAllUsersAsync();  // review this 
    }
}
