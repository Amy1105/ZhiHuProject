using Core.Common;
using SharedKernel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.AppUserAggregate.Entites
{
    public class AppUser: BaseAuditEntity,IAggregateRoot
    {
        protected AppUser() { }

        public AppUser(int userId)
        {

        }

        public string? Nickname {  get; set; }

        public string? Avatar { get; set; }

        public string? Bio {  get; set; }

        /// <summary>
        /// 关注列表
        /// </summary>
        public ICollection<FollowUser> Followees { get; set; } = new List<FollowUser>();

        /// <summary>
        /// 粉丝列表
        /// </summary>
        public ICollection<FollowUser> Followers { get; set; }= new List<FollowUser>();

        /// <summary>
        /// 关注的问题列表
        /// </summary>
        public ICollection<FollowQuestion> FollowQuestions { get; set; }=new List<FollowQuestion>();
    }
}
