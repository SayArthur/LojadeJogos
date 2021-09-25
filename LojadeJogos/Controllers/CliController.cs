using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojadeJogos.Models;
using LojadeJogos.Repositorio;

namespace LojadeJogos.Controllers
{
    public class CliController : Controller
    {

        public ActionResult Cli()
        {
            var cliente = new ModelCi();
            return View(cliente);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult CadCli(ModelCi cliente)
        {
            ac.CadastrarCli(cliente);
            return View(cliente);
        }
    }
}