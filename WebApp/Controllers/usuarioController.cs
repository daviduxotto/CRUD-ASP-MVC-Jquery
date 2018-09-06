using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class usuarioController : Controller
    {
        dUsuario obj = new dUsuario();

        public ActionResult listar()
        {
            
            return View();
        }

       public ActionResult getAllUser()
        {
         List<eUsuario> listUsuarios = obj.getAllUser();
         return Json(new { data = listUsuarios }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult edit(string id)
         {
            eUsuario usuario = new eUsuario();
            usuario.codUsuario =id;
            usuario = obj.getOneUser(usuario);
            return PartialView(usuario);
         }
    }
}