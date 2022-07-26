using DataAccess.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Permite consultar todos los clientes
        /// </summary>
        /// <returns>Listado de clientes</returns>
        public async Task<List<Customer>> GetAllCustomer()
        {
            var customers = await _context.Customers.ToListAsync();
            return customers;
        }

        /// <summary>
        /// Permite consultar un cliente por Id
        /// </summary>
        /// <param name="id">Id del cliente a consultar</param>
        /// <returns>Cliente consultado</returns>
        public bool GetCustomerById(int id)
        {
            var customer = _context.Customers.Any(x => x.id == id);
            return customer;
        }
    }
}