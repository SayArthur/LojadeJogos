using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojadeJogos.Models;
using System.Web.Mvc;

namespace LojadeJogos.Controllers
{
    public class GameController : Controller
    {

        public ActionResult Jogo()
        {
            var jogo = new ModelGame();
            return View(jogo);
        }
        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult CadGame(ModelGame jogo)
        {
            ac.CadastrarGame(jogo);
            return View("Resultado",jogo);
        }
        

    }
}