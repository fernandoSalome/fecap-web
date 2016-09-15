using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fecap.Aula01.Web.Controllers
{
    public class PastelController : Controller
    {
        [HttpGet] //Abre a tela com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }
	}
}