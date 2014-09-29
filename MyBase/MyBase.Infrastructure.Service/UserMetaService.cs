using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Infrastructure.Core.ServiceInterface;
using MyBase.Domain.Interface;
using MyBase.Domain.Core.Entities;

namespace MyBase.Infrastructure.Service
{
    public class UserMetaService : IUserMetaService
    {
        private readonly IUserRepo _userRepo;

        public UserMetaService(IUserRepo userRepo) 
        {
            _userRepo = userRepo;
        }
        public List<UserProfile> GetAllUsers()
        {
            return _userRepo.GetAllUserName();
        }
    }
}
