using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TchokopassEnterprises4.ViewModels;

namespace TchokopassEnterprises4.Services
{
    public interface IEmailService
    {
        Task SendEmail(EmailModel objModelMail);
    }
}
