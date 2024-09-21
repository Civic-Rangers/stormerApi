using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
     

        public UserService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<UserDTO> CreateUserAsync(UserDTO user)
        {
            var userEntity = _mapper.Map<User>(user);
            _repositoryManager.User.CreateUser(userEntity);
            await _repositoryManager.SaveAsync();
            var userToReturn = _mapper.Map<UserDTO>(userEntity);
            return userToReturn;
        }

        public async Task<UserDTO> getUserByUsernameAndPassword(UserDTO user, bool trackChanges)
        {
            var userToReturn = await _repositoryManager.User.GetUserByNameandPass(user, false);
            return userToReturn;
        }
    }
}
