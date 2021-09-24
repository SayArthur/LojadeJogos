using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojadeJogos.Models;
using LojadeJogos.Repositorio;

namespace LojadeJogos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        Acoes ac = new Acoes();

        public ActionResult Jogo()
        {
            var jogo = new ModelGame();
            return View(jogo);
        }


        [HttpPost]
        public ActionResult CadJogo(ModelGame jogo)
        {
            ac.CadastrarGame(jogo);
            return View(jogo);
        }

        public ActionResult ListarGame()
        {
            var ExibeJogo = new Acoes();
            var TodosJogos = ExibeJogo.ListarGame();
            return View(TodosJogos);
        }

        public ActionResult Cli()
        {
            var cliente = new ModelCi();
            return View(cliente);
        }


        [HttpPost]
        public ActionResult CadCli(ModelCi cliente)
        {
            ac.CadastrarCli(cliente);
            return View(cliente);
        }

        public ActionResult ListarCli()
        {
            var ExibeCli = new Acoes();
            var TodosCli = ExibeCli.ListarCli();
            return View(TodosCli);
        }

        public ActionResult Func()
        {
            var funcio = new ModelFunc();
            return View(funcio);
        }


        [HttpPost]
        public ActionResult CadFunc(ModelFunc func)
        {
            ac.CadastrarFunc(func);
            return View(func);
        }

        public ActionResult ListarFuncionario()
        {
            var ExibeFunc = new Acoes();
            var TodosFunc = ExibeFunc.ListarFuncionario();
            return View(TodosFunc);
        }

    }
}