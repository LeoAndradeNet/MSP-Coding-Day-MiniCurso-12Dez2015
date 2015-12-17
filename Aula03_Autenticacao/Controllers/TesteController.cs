using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula03_Autenticacao.Controllers
{
    [Authorize]
    public class TesteController : Controller
    {
        // GET: Teste
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teste()
        {
            return View();
        }
    }
}