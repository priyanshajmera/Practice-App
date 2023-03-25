using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeApi.Entities;

namespace PracticeApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}