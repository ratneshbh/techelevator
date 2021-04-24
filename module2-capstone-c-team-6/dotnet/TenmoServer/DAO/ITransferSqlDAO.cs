using System.Collections.Generic;
using TenmoServer.Models;

namespace TenmoServer.DAO
{
    public interface ITransferSqlDAO
    {
        List<Transfer> ShowHistory(int id);
        Transfer ShowTransfer(int transferId);
        Transfer CreateTransfer(Transfer transfer);
    }
}
