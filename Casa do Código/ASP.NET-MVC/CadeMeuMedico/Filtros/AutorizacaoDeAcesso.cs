using CadeMeuMedico.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Filtros
{
    [HandleError] //gerenciador de erros
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Method,
        Inherited = true,
        AllowMultiple = true
        )]

    public class AutorizacaoDeAcesso : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filtroDeContexto)
        {
            //base.OnActionExecuting(filterContext);
            var controller = filtroDeContexto.ActionDescriptor.ControllerDescriptor.ControllerName;

            var action = filtroDeContexto.ActionDescriptor.ActionName;

            if(controller != "Home" || action != "Login")
            {
                if(RepositorioUsuario.VerificaSeUsuarioEstaLogado() == null)
                {
                    filtroDeContexto.RequestContext.HttpContext.Response.Redirect("/Home/Login?Url=" + filtroDeContexto.HttpContext.Request.Url.LocalPath);
                }
            }


        }
    }
}