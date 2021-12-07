using Albina.BuisnessLogic.Core.Interfaces;
using Albina.BuisnessLogic.Core.Models;
using Albina.DataAccessCore.Interfaces;
using Albina.DataAccessCore.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Shareds.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albina.BuisnessLogic.Core.Servives
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IContext _context;

        public UserService(IMapper mapper, IContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Task<UserInformationBlo> Auth(UserIndentityBlo userIndentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int numberPrefix, int number)
        {
            throw new NotImplementedException();
        }

        public async Task<UserInformationBlo> Get(int userId)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(h => h.Id == userId);
            if (user = null) throw new NotFoundExceptions($"Пользователь с id{userId} не найден");
            UserInformationBlo userInformationBlo = await ConvertToUserInformation(user);
            return userInformationBlo;
        }

        public Task<UserInformationBlo> Register(UserIndentityBlo userIndentityBlo)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Update(UserIndentityBlo userIndentityBlo, UserUpdateBlo userUpdateBlo)
        {
            throw new NotImplementedException();
        }

        private async Task<UserInformationBlo> ConvertToUserInformation(UserRto userRto)
        {
            if (userRto == null) throw new ArgumentException(nameof(userRto));

            UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);
            return userInformationBlo;
        }
    }
}
