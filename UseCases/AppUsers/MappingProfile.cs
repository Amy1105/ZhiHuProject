using AutoMapper;
using Core.AppUserAggregate.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.AppUsers.Commands;

namespace UseCases.AppUsers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, CreatedAppUserDto>();
        }
    }
}
