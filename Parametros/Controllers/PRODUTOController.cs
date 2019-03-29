using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parametros.Controllers
{
    public class PRODUTOController : Controller
    {

        public ActionResult Buscar(int prd)
        {
            string retorno = string.Empty;
            string linkretorno = string.Empty;
            switch(prd)
            {
                case 1:
                    retorno = "sansung galaxy";
                    linkretorno = "https://www.samsung.com/br/smartphones/galaxy-s9/";
                    break;

                case 5:
                    retorno = "iphone 3";
                    linkretorno = "https://www.apple.com/br/iphone-xs/";
                    break;

                default:
                    retorno = "Nokia";
                    linkretorno = "https://br.gearbest.com/cell-phones/pp_009787976351.html";
                    break;
                    

            }
             
            ViewBag.Produto = retorno;
            ViewBag.link = linkretorno;
            return View();
        }
    }
}