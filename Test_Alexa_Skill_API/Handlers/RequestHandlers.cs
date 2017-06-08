using Test_Alexa_Skill_API.Models;

namespace Test_Alexa_Skill_API.Handlers
{
    public class RequestHandlers
    {
        public static AlexaResponse LaunchRequestHandler(AlexaRequest request)
        {
            AlexaResponse response = new AlexaResponse("Welcome to Demo Bot. How may I help?");
            response.Response.Card.Title = "Demo Bot Opened";
            response.Response.Card.Content = "Ask for a Joke or a Programming Language";

            response.Response.Reprompt.OutputSpeech.Text = "You can ask for a joke or a programming language";
            response.Response.ShouldEndSession = false;

            return response;
        }

        public static AlexaResponse IntentRequestHandler(AlexaRequest request)
        {
            AlexaResponse response = null;

            switch (request.Request.Intent.Name)
            {
                case "GetLanguage":
                    response = IntentHandlers.ProgrammingLanguageHandler(request);
                    break;
                case "TellProgrammingJoke":
                    response = IntentHandlers.ProgrammingJokeHandler(request);
                    break;
            }

            return response;
        }

        public static AlexaResponse SessionEndedRequestHandler(AlexaRequest request)
        {
            AlexaResponse response = new AlexaResponse("Have a nice day!");
            response.Response.Card.Title = "Demo Bot Ended";
            response.Response.Card.Content = "Come back soon!";
            response.Response.ShouldEndSession = true;

            return response;
        }

    }
}