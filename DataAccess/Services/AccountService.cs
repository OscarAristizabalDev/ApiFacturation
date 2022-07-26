using DataAccess.Data;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class AccountService
    {
        private readonly ApplicationDbContext _context;
        private readonly CustomerService _customerService;

        public AccountService(ApplicationDbContext context, CustomerService customerService)
        {
            this._context = context;
            this._customerService = customerService;
        }

        /// <summary>
        /// Permite crear una factura
        /// </summary>
        /// <param name="account">Factura a crear</param>
        /// <returns>La factura creada</returns>
        public async Task<Account> CreateAccount(Account account)
        {
            // Se valida la existencia del cliente
            var existCustomer = _customerService.GetCustomerById(account.customerId);
            if (!existCustomer)
            {
                account.customerId = 0;
                return account;
            }
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            return account;
        }

    }
}
