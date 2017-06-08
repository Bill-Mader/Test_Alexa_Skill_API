using System;
using System.Collections.Generic;
using Test_Alexa_Skill_API.Models;

namespace Test_Alexa_Skill_API.Generators
{
    public class JokeGenerator
    {
        List<Joke> Jokes = new List<Joke>();

        public JokeGenerator()
        {
            Jokes.Add(new Joke("How many programmers does it take to screw in a light bulb?", "None. It's a hardware issue."));
            Jokes.Add(new Joke("A programmer puts two glasses on his bedside table before going to sleep.", "A full one, in case he gets thirsty, and an empty one, in case he doesn't."));
            Jokes.Add(new Joke("A programmer is heading out to the grocery store, so his wife tells him \"Get a gallon of milk, and if they have eggs, get a dozen.\"", "He returns with 13 gallons of milk."));
            Jokes.Add(new Joke("Why do Java programmers have to wear glasses?", "Because they don't see sharp."));
        }

        public Joke GetJoke()
        {
            return Jokes[(new Random()).Next(0, Jokes.Count)];
        }
    }
}