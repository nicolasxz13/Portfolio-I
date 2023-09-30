
using Microsoft.AspNetCore.Mvc;

namespace Portafolio.Controllers{
    public class Portafolio : Controller{
        [HttpGet]
        [Route("")]
        public string index(){
            return "This is my Index";
        }

        [HttpGet]
        [Route("/projects")]
        public string getAllProjects(){
            return "These are my projects";
        }

        [HttpGet]
        [Route("/contact")]
        public string contact(){
            return "This is my Contact";
        }

    }
}