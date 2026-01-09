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
    public class ReverseItAlphaNumController : ControllerBase
    {
        private readonly ReverseItService _reverseItAlphaNum;

        public ReverseItAlphaNumController(ReverseItService reverseItAlphaNum)
        {
            _reverseItAlphaNum = reverseItAlphaNum;
        }

        [HttpPost("/{sequence}")]
        public string ReverseIt(string sequence)
        {
            return _reverseItAlphaNum.ReverseItAlphaNum(sequence);
        }
    }
}