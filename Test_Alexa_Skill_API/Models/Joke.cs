namespace Test_Alexa_Skill_API.Models
{
    public class Joke
    {
        public Joke(string setup, string punchline)
        {
            Setup = setup;
            Punchline = punchline;
        }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}