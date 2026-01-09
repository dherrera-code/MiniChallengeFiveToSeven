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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _madlibStory;
        public MadLibController(MadLibService madLibStory)
        {
            _madlibStory = madLibStory;
        }
        [HttpPost("MadLib/{name}/{occupation}/{adjective1}/{adjective2}/{location}/{weather}/{creature}/{mood1}/{mood2}/{pronoun}/{object1}/{animalSound}/{food}")]

        public string MadLib(string name, string pronoun, string occupation, string adjective1, string adjective2, string location, string weather, string creature, string mood1, string mood2, string object1, string animalSound, string food)
        {
            return _madlibStory.MadLib(name, pronoun, occupation, adjective1, adjective2, location, weather, creature, mood1, mood2, object1, animalSound, food);
        }
    }
}