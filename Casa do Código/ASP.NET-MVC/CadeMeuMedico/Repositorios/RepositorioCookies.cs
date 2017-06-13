using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Repositorios
{
    public class RepositorioCookies
    {
        public static void RegistraCookieAutenticacao(long IDUsuario)
        {

            //Criando um objeto cookie
            HttpCookie UserCookie = new HttpCookie("UserCookieAuthentication");

            //Setando o ID do usuario no cookie
            UserCookie.Values["IDUsuario"] = Convert.ToString(IDUsuario);// precisa criptografar com o id - CadeMeuMedico.Repositorios

            //Definindo o prazo de vida do cookie
            UserCookie.Expires = DateTime.Now.AddDays(1);

            //adicionando o cookie no contexto da  aplicacao 
            HttpContext.Current.Response.Cookies.Add(UserCookie);
        }
    }
}