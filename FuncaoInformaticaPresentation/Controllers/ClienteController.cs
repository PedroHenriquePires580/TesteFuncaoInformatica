using FuncaoInformaticaPresentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuncaoInformaticaPresentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(ClienteViewModel clienteViewModel)
        {
            return View(clienteViewModel);
        }

        public ActionResult Editar(int? Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Editar(ClienteViewModel clienteViewModel)
        {
            return View();
        }
    }
}