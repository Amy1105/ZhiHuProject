using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.AppUsers
{
    public class UserInfoDto
    {
        public int Id { get; set; }

        public string? Nickname { get; set; }

        public string? Avatar { get; set; }

        public string? Bio { get; set; }

        public int FolloweesCount { get; set; }

        public int FollowersCount { get; set; }
    }
}
