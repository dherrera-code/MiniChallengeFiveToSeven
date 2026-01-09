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
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumsOnlyService _reverseNums;
        public ReverseItNumbersController(ReverseItNumsOnlyService reverseNum)
        {
            _reverseNums = reverseNum;
        }

        [HttpPost("Numbers/{sequence}")]
        public string ReverseNumbers(string sequence)
        {
            return _reverseNums.ReverseItNums(sequence);
        }

    }
}