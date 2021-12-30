using AdnRenting.Application.Dto;
using AdnRenting.Application.Interfaces;
using AdnRenting.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IMapper mapper;

        public UserService(IRepository<User> userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<UserInfoDto>> GetUserList()
        {
            var userInfoCollection =  await userRepository.List();
            var unique = mapper.Map<UserInfoDto>(userInfoCollection.FirstOrDefault());
            return mapper.Map<IEnumerable<UserInfoDto>>(userInfoCollection);
        }

        public async Task<User> PostUser(string name)
        {
            var user = await userRepository.Add(new User() { Id=Guid.NewGuid(), Name=name});
            return user;
        }
    }
}
