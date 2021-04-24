using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TenmoServer.DAO;
using TenmoServer.Models;

namespace TenmoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class TransferController : ControllerBase
    {
        private static ITransferSqlDAO transferDAO;
        public TransferController(ITransferSqlDAO _transferDAO)
        {
            transferDAO = _transferDAO;
        }

        [HttpGet("all")]       //transfer
        public ActionResult<List<Transfer>> ListAllTransfers()
        {
            int userId = int.Parse(User.FindFirst("sub")?.Value);
            if (transferDAO.ShowHistory(userId).Count == 0)
            {
                return NoContent();
            }
            else
            {
                return Ok(transferDAO.ShowHistory(userId));
            }
        }
        [HttpGet]       //transfer/{id}
        public ActionResult<Transfer> ShowSpecificTransfer()
        {
            int userId = int.Parse(User.FindFirst("sub")?.Value);
            if (transferDAO.ShowTransfer(userId) == null)
            {
                return NotFound("Could not find transfer");
            }
            else
            {
                return transferDAO.ShowTransfer(userId);
            }
        }
        [HttpPost]  //create entry in database      //transfer
        public ActionResult<Transfer> CreateTransferEntry(Transfer transfer)
        {
            return transferDAO.CreateTransfer(transfer);
        }
    }
}
