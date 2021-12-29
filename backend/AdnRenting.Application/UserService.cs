using AdnRenting.Application.Interfaces;
using AdnRenting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Application
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUserList()
        {
            return await userRepository.List();
        }
    }
}
