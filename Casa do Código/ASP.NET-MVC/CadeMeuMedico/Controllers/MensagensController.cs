using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MensagensController : Controller
    {
        
        public ActionResult BomDia()
        {
            return Content("Bom dia.. a todos");
        }

        public ActionResult BoaTarde()
        {
            return Content("Boa tarde.. não durma");
        }
    }
}