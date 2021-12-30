using AdnRenting.Application.Dto;
using AdnRenting.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserInfoDto>> GetUserList();

        Task<User> PostUser(string name);
    }
}
