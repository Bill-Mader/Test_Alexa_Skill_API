using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Alexa_Skill_API.Handlers;
using Test_Alexa_Skill_API.Models;

namespace Test_Alexa_Skill_API.Controllers
{
    public class AlexaController : ApiController
    {
        private const string ApplicationId = "amzn1.ask.skill.0b4c361e-1e4b-4f87-873c-a1a4af2c198b";

        [HttpPost, Route("api/alexa")]
        public AlexaResponse AllegientDemo(AlexaRequest request)
        {

            if (request.Session.Application.ApplicationId != ApplicationId)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));

            var totalSeconds = (DateTime.UtcNow - request.Request.Timestamp).TotalSeconds;
            if (totalSeconds < -15 || totalSeconds > 150)
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest));

            AlexaResponse response = null;

            if (request != null)
            {
                switch (request.Request.Type)
                {
                    case "LaunchRequest":
                        response = RequestHandlers.LaunchRequestHandler(request);
                        break;
                    case "IntentRequest":
                        response = RequestHandlers.IntentRequestHandler(request);
                        break;
                    case "SessionEndedRequest":
                        response = RequestHandlers.SessionEndedRequestHandler(request);
                        break;
                }
            }

            return response;
        }
    }
}