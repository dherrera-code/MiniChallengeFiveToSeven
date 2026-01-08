using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using miniCh5.Services;

namespace miniCh5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {

        private readonly OddOrEvenService _oddOrEven;
        public OddOrEvenController(OddOrEvenService oddOrEven)
        {
            _oddOrEven = oddOrEven;
        }
        [HttpPost("{number}")]
        public string OddOrEven(int number)
        {
            return _oddOrEven.OddOrEven(number);
        }
    }
}