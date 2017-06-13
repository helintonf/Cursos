using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadeMeuMedico.Repositorios;

namespace CadeMeuMedico.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
       [HttpGet]
       public JsonResult AutenticacaoDeUsuario(string Login,string Senha)
        {
            if (RepositorioUsuario.AutenticarUsuario(Login, Senha))
            {
                return Json(new { OK = true, Mensagem = "Usuario autenticado. Redirecinando..." }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { OK = false, Mensagem = "Usuario não encontrado. Tente novamente." }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}