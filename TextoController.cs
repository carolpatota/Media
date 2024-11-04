using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carolina_1.Controllers
{
    public class TextoController : Controller
    {
        [Route("conversa/{olaola}")]
        public String Stalker( string olaola)
        {
            return "Quem incomoda?";
        }

        [Route("conversa2/{seuadmirador}")]
        public String Stalker2(string seuadmirador)
        {
            return "Como te chamas?";
        }

        [Route("conversa3/{Joaobobao}")]
        public String Stalker3(string Joaobobao)
        {
            return "Idiota!";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

