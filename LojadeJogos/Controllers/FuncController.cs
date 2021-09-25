using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LojadeJogos.Models;
using System.Web.Mvc;

namespace LojadeJogos.Controllers
{
    public class FuncController : Controller
    {

        public ActionResult Func()
        {
            var funcio = new ModelFunc();
            return View(funcio);
        }
        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult CadFunc(ModelFunc func)
        {
            ac.CadastrarFunc(func);
            return View(func);
        }

    }
}