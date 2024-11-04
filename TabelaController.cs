using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carolina_1.Controllers
{
    public class TabelaController : Controller
    {
        [Route("criartabela/{id1}/{id2}/{cor}")]

        public ContentResult Teste(int id1, int id2, string cor)
        {
            {
                ContentResult c1 = new ContentResult();
                c1.ContentType = "text/html";

                string s = "<table border=1 style='background-color:" + cor + ";margin-left:50px'>";

                for (int i = 0; i < id1; i++)
                {
                    s += "<tr>";
                 
                    for (int j = 0; j < id2; j++)
                    {
                        s = s + "<td>Carolina</td>";
                    }
                    s += "</tr>";
                }

                s +=  "</table>";

                c1.Content = s;
                return c1;
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

