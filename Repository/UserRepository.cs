using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Shared.DataTransferObjects;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateUser(User user) => Create(user);

        public Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByIdAsync(Guid id, bool trackChanges) =>
                    await FindByCondition(u => u.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        public async Task<UserDTO> GetUserByNameandPass(UserDTO user, bool trackChanges) =>
         await FindByCondition(u => u.Name.Equals(user.Name)
                       && u.Password.Equals(user.Password),
                    trackChanges).Select(u => new UserDTO
                    {
                        Id = u.Id,
                        Name = u.Name,
                        Password = u.Password
                    }).SingleOrDefaultAsync();
    }

}
