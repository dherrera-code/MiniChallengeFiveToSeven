using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniCh5.Services
{
    public class MadLibService
    {
        public string MadLib(string name, string pronoun, string occupation, string adjective1, string adjective2, string location, string weather, string creature, string mood1, string mood2, string object1, string animalSound, string food)
        {
            return $"\nThere was once a(n) {adjective2} {occupation} named {name} who always loved to explore (the) {location}. On a particular {weather} day, {name} happened to run into a(n) {creature} who stood in (his/her) path. {name} who felt {mood1} had to quell the {creature}'s {mood2} so {pronoun} pulled out a(n) {object1}. They fought and the {creature} {animalSound}ed however with a long fought battle the {occupation} prevailed. With the {creature} dealt with and the path is clear, the {occupation} felt {adjective1}. Now {pronoun} can return home and eat some quality {food}.";
        }
    }
}