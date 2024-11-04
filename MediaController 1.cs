using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carolina_1.Controllers
{
    public class MediaController1 : Controller
    {
        [Route("lista/{op1}/{op2}/{op3}")]
        public String Media(int op1, int op2, int op3)
        {
            int media = (op1 + op2 + op3)/3;


            string med_final = "A média dos operadores é:" + media;
            return med_final;  
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

