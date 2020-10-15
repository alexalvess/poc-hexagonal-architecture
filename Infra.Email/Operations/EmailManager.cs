using Domain.Adapters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Email.Operations
{
    public class EmailManager : IEmailAdapter
    {
        public Task SendEmail(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
