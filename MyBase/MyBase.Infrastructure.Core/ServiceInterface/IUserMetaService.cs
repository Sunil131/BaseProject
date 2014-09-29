using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBase.Domain.Core.Entities;

namespace MyBase.Infrastructure.Core.ServiceInterface
{
    public interface IUserMetaService
    {
        List<UserProfile> GetAllUsers();
    }
}
