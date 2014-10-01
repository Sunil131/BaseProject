using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Infrastructure.Core.ServiceInterface;
using MyBase.Domain.Interface;
using MyBase.Domain.Core.Entities;
using MyBase.Infrastructure.Core.PresentationModel;

namespace MyBase.Infrastructure.Service
{
    public class UserMetaService : IUserMetaService
    {
        private readonly IUserRepo _userRepo;

        public UserMetaService(IUserRepo userRepo) 
        {
            _userRepo = userRepo;
        }
   
       public UserModel GetAllUsers()
        {

             UserModel userModel = new UserModel
             {
                 UserNames = _userRepo.GetAllUserName()
             };

             return userModel;
        }
    }
}
