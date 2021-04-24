using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.Models
{
    public class SendingTransfer
    {
        public int RecipientId { get; set; }
        public decimal Amount { get; set; }
    }
}
