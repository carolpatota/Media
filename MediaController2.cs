using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Carolina_1.Controllers
{
    public class MediaController2 : Controller
    {
        [Route("lista/{op1}/{op2}/{op3}")]
        public ContentResult Media(int op1, int op2, int op3)
        {
            int media = (op1 + op2 + op3)/3;

            ContentResult c1 = new ContentResult();

            c1.ContentType = "text/html";

            string med_final = "<table border=10 style='background-color:lightblue;border-color:yellow;color:red'>" +
                "<tr><td>" + "Media:" + media + "</td></tr>";
         
            c1.Content = med_final;
            return c1;  
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}

