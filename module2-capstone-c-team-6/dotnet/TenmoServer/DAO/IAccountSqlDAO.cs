using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
    public interface IAccountSqlDAO
    {
        public Account AccountBalance(int userId);

        public List<Account> ListUsers();

        public bool TransferTo(decimal amount, int userId, int recipientId);


    }
}
