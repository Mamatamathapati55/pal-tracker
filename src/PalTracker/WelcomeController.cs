<<<<<<< HEAD
=======
    
>>>>>>> 7094c722c76d5a711fc2c0374e8bc73561f366cd
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        private readonly WelcomeMessage _message;

        [HttpGet]
        public string SayHello() => _message.Message;

        public WelcomeController(WelcomeMessage message)
        {
            _message = message;
        }
    }
}