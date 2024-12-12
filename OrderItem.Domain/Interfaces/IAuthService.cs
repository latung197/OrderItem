using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderItem.Domain.Interfaces
{
    public interface IAuthService
    {
        bool VerifyPassword(string password, string hash);
        string HashPassword(string password);
    }
}
