using FMSWindows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSWindows.Services.Abstract
{
    public interface IUser
    {
        Task<SingleResponseModel<UserDetail>> GetUserDetails();
    }
}
