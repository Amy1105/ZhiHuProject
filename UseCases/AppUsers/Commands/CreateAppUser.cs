using AutoMapper;
using Core.AppUserAggregate.Entites;
using SharedKernel.Messaging;
using SharedKernel.Repositoy;
using SharedKernel.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.AppUsers.Commands
{
    public record CreatedAppUserDto(int Id, string NickName);
    public record CreateAppUserCommand(int UserId) : ICommand<Result<CreatedAppUserDto>>;
    public class CreateAppUserCommandHandler(IRepository<AppUser> userRepo, IMapper mapper) : ICommandHandler<CreateAppUserCommand, Result<CreatedAppUserDto>>
    {
        public async Task<Result<CreatedAppUserDto>> Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            var user = userRepo.Add(new AppUser(request.UserId)
            {
                Nickname = $"新用户{request.UserId}"
            });

            await userRepo.SaveChangesAsync(cancellationToken);

            return Result.Success(mapper.Map<CreatedAppUserDto>(user));
        }
    }
}