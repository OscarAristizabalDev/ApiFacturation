using DataAccess.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturation.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    public class AccountController : Controller
    {
        private readonly AccountService accountService;
        public AccountController(AccountService accountService)
        {
            this.accountService = accountService;
        }

        /// <summary>
        /// Permite crear una nueva factura
        /// </summary>
        /// <param name="newAccount">Factura a crea</param>
        /// <returns>El estado de la solicitud</returns>
        [HttpPost]
        public async Task<ActionResult<Account>> Create(Account newAccount)
        {
            var account = await accountService.CreateAccount(newAccount);

            if (account.customerId == 0)
            {
                return NotFound("El cliente no se encuentra registado");
            }

            return Ok(account);
        }
    }
}
