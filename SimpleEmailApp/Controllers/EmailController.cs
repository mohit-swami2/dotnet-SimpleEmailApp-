using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using MimeKit;
using MimeKit.Text;
using SimpleEmailApp.Model;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailServices _services;

        public EmailController(IEmailServices services)
        {
            _services = services;
        }
        [HttpPost]
        public IActionResult SendMail(EmailDto request)
        {
            _services.SendMail(request);
            return Ok("Done");
        }
    }
}