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
    [Route("api/customers")]
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Permite consultar todos los clientes
        /// </summary>
        /// <returns>El estado de la solicitud</returns>
        [HttpGet]
        public async Task<ActionResult<Customer>> GetAll()
        {
            var customers = await _customerService.GetAllCustomer();
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }
    }
}
