using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BackEndApplication.Interfaces;
using BackEndApplication.Models;
using BackEndApplication.Requests;
using BackEndApplication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BackEndApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public TransactionController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var transactions = _accountService.GetAccountTransactions();
            return Ok(_mapper.Map<List<TransactionResponse>>(transactions));
        }

        [HttpPost]
        public IActionResult Commit([FromBody] TransactionRequest model)
        {
            _accountService.CreateTransaction(model.Type, model.Amount);
            return Ok();
        }
    }
}