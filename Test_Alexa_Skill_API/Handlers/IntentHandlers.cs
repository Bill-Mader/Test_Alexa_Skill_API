using Test_Alexa_Skill_API.Generators;
using Test_Alexa_Skill_API.Models;

namespace Test_Alexa_Skill_API.Handlers
{
    public class IntentHandlers
    {
        public static AlexaResponse ProgrammingLanguageHandler(AlexaRequest request)
        {
            string type = request.Request.Intent.Slots["Type"].value.ToString();
            string language = (new ProgrammingLanguageGenerator()).GetProgrammingLanguage(type);
            AlexaResponse response = new AlexaResponse();

            if (language != null)
            {
                response = CreateResponse(type, language);
            }
            else
            {
                response = CreateErrorResponse(type);
            }

            return response;
        }

        public static AlexaResponse ProgrammingJokeHandler(AlexaRequest request)
        {
            Joke joke = (new JokeGenerator()).GetJoke();
            AlexaResponse response = new AlexaResponse();

            response.Response.Card.Title = joke.Setup;
            response.Response.Card.Content = joke.Punchline;
            response.Response.OutputSpeech.Text = joke.Setup + " " + joke.Punchline;
            response.Response.Reprompt.OutputSpeech.Text = "You can ask for another language or a joke.";
            response.Response.ShouldEndSession = false;

            return response;
        }

        private static AlexaResponse CreateResponse(string type, string language)
        {
            AlexaResponse response = new AlexaResponse();

            response.Response.Card.Title = "Retrieved a " + type + " Language";
            response.Response.Card.Content = "Your " + type + " Language is " + language + ".";
            response.Response.OutputSpeech.Text = "I suggest using " + language + ".";
            response.Response.Reprompt.OutputSpeech.Text = "You can ask for another language or a joke.";
            response.Response.ShouldEndSession = false;

            return response;
        }

        private static AlexaResponse CreateErrorResponse(string type)
        {
            AlexaResponse response = new AlexaResponse();

            response.Response.OutputSpeech.Text = "I'm sorry. I don't know any " + type + " languages.";
            response.Response.Reprompt.OutputSpeech.Text = "You can ask for a different language or a joke.";
            response.Response.ShouldEndSession = false;

            return response;
        }
    }
}