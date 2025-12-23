using SharedKernel.Messaging;
using SharedKernel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Common.Interfaces;

namespace UseCases.AppUsers.Queries
{
    public record GetUserInfoQuery(int id):IQuery<Result<UserInfoDto>>;

    public class GetUserInfoQueryHandler(IDataQueryService queryService) : IQueryHandler<GetUserInfoQuery, Result<UserInfoDto>>
    {
        public async Task<Result<UserInfoDto>> Handle(GetUserInfoQuery request, CancellationToken cancellationToken)
        {
          var queryable=  queryService.AppUsers.Where(x => x.Id == request.id).Select(u => new UserInfoDto
            {
                Id = u.Id,
                Nickname = u.Nickname,
                Avatar = u.Avatar,
                Bio = u.Bio,
                FolloweesCount = u.Followees.Count,
                FollowersCount = u.Followers.Count
            });

            var appUserInfo = await queryService.FirstOrDefaultAsync(queryable);
            return appUserInfo is null ?  Result.NotFound():Result.Success(appUserInfo);
        }
    }
}
