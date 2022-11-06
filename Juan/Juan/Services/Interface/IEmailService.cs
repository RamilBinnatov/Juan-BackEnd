using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Services.Interface
{
    interface IEmailService
    {
        void Send(string to, string subject, string body, string from = null);
    }
}
