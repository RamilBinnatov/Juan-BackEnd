
namespace Juan.Services.Interface
{
    public interface IEmailService
    {
        void Send(string to, string subject, string body, string from = null);
    }
}
