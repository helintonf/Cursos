using CadeMeuMedico.Models;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CadeMeuMedico.Repositorios
{
    public class RepositorioUsuario
    {

        public static bool AutenticarUsuario(string login, string senha)
        {
            var senhaCriptogradafa = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "sha1");

            try
            {
                using (CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities())
                {
                    var QueryAutenticaUsuarios = db.Usuarios.Where(x => x.Login == login && x.Senha == senhaCriptogradafa).SingleOrDefault();

                    if (QueryAutenticaUsuarios == null)
                    {
                        return false;
                    }
                    else
                    {
                        RepositorioCookies.RegistraCookieAutenticacao(QueryAutenticaUsuarios.IDUsuario);
                        return true;

                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        //verifica status do usuario
        public static Usuarios RecuperaUsuarioPorID(long IDUsuario)
        {
            try
            {
                using(CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities())
                {
                    var Usuario = db.Usuarios.Where(u => u.IDUsuario == IDUsuario).SingleOrDefault();
                    return Usuario;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        //verifica se esta logado
        public static Usuarios VerificaSeUsuarioEstaLogado()
        {
            var Usuario = HttpContext.Current.Request.Cookies["UserCookieAuthentication"];

            if(Usuario == null)
            {
                return null;
            }
            else
            {
                //alterar para repositorio da criptografia
                //long IDUsuario = Convert.ToInt64(RepositorioCriptografia.Descriptografar(Usuario.Values["IDUsuario"]));

                long IDUsuario = Convert.ToInt64(Usuario.Values["IDUsuario"]);

                var UsuarioRetornado = RecuperaUsuarioPorID(IDUsuario);

                return UsuarioRetornado;
            }
        }
        
    }
}