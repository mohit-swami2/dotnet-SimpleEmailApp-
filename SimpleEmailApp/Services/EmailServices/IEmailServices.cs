using SimpleEmailApp.Model;

namespace SimpleEmailApp.Services.EmailServices
{
    public interface IEmailServices
    {
        void SendMail(EmailDto request);
        
    }
}
