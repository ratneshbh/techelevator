using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TenmoServer.DAO;
using TenmoServer.Models;

namespace TenmoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private static IAccountSqlDAO accountDAO; //first set up DAO

        public AccountController(IAccountSqlDAO _accountDAO)  //passing in interface as tool for mediating between controller and model
        {
            accountDAO = _accountDAO;
        }
        [HttpGet("all")]
        public ActionResult<List<Account>> ListUsers()
        {
            if (accountDAO.ListUsers().Count == 0)
            {
                return NotFound("Did not pull users");
            }
            else
            {
                return Ok(accountDAO.ListUsers());
            }
        }
        [HttpGet]
        public ActionResult<Account> GetBalance()
        {
            int userId = int.Parse(User.FindFirst("sub")?.Value);
            return Ok(accountDAO.AccountBalance(userId));
        }
        [HttpPut]      //account
        public ActionResult<bool> TransferFunds(SendingTransfer sendingTransfer)
        {
            int userId = int.Parse(User.FindFirst("sub")?.Value);
            decimal amount = sendingTransfer.Amount;
            int recipientId = sendingTransfer.RecipientId;
            bool isSuccessful = accountDAO.TransferTo(amount, userId, recipientId);
            if (!isSuccessful)
            {
                return NotFound("Transfer cannot be completed");
            }
            else
            {
                return Ok(true);
            }
        }
    }
}
