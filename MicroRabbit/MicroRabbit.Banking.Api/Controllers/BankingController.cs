using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    public class BankingController : Controller
    {
        private readonly IAccountService _service;

        public BankingController(IAccountService service)
        {
            _service = service;
        }


       [HttpGet]
       public ActionResult<IEnumerable<Account>> GetAccounts()
        {
            return Ok(_service.GetAccounts());
        }
    }
}