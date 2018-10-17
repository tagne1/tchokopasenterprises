using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TchokopassEnterprises4.Services;
using TchokopassEnterprises4.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TchokopassEnterprises4.Controllers
{
    public class ContactUsMailController : Controller
    {
        private readonly IEmailService _emailService;
        public ContactUsMailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        // POST: api/ContactUsMail
        [Route("api/[controller]")]
        [HttpPost]
        public async Task<IActionResult> SendEmailAsync([FromBody]EmailModel objModelMail)
        {
            await _emailService.SendEmail(objModelMail);
            return Ok();
        }
    }
}

