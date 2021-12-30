using System;

namespace AdnRenting.Application.Dto
{
    public class UserInfoDto
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PendingOrders { get; set; } = 0;
        public int CompletedOrders { get; set; } = 0;
    }
}
