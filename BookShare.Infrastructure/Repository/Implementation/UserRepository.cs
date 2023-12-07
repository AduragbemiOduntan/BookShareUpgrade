using BookShare.Domain.Model;
using BookShare.Infrastructure.ApplicationContext;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace BookShare.Infrastructure.Repository.Implementation
{
    internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly DbSet<User> _user;
        public UserRepository(BookShareContext bookShareContext): base(bookShareContext)
        {
            _user = bookShareContext.Set<User>();
        }

        public void CreateUser(User user)
        {
            CreateAsync(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public Task<User> GetAllUsersAsync()  // please review this 
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByEmailAsync(string email, bool trackChanges)
        {
            return await _user.Where(u => u.Email.Contains(email, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefaultAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _user.FindAsync(id);
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }
    }
}
