using Fecap.Aula01.Web.BancoDados;
using Fecap.Aula01.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fecap.Aula01.Web.Controllers
{
    public class PastelController : Controller
    {
        private Banco banco = new Banco();

        [HttpGet] //Abre a tela com o formulário
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Cadastra as informações no banco de dados
        public ActionResult Cadastrar(Pastel pastel)
        {
            //Cadastrar um pastel no banco de dados
            banco.Pasteis.Add(pastel);
            //Salvar as alterações
            banco.SaveChanges();
            //Mostrar uma mensagem de sucesso
            TempData["msg"] = "Cadastrado!";
            return View();
        }
	}
}