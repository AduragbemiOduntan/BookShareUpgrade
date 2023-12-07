using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Services.Abstraction
{
    public interface IEmailService
    {
        Task SendEmail(string email, string title, string message);
    }
}
