using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Adapters
{
    public interface IEmailAdapter
    {
        Task SendEmail(string from, string to, string subject, string body);
    }
}
