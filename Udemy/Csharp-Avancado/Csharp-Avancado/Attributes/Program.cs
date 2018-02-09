using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Attributes
{
    [MeuAtributo("AtributoClasse", Descricao = "Descricao")]
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var user = new Usuario() { Nome = "Helinton", Email = "casa", Senha = "123456" };



            ValidationContext contexto = new ValidationContext(user);

            List<ValidationResult> resultados = new List<ValidationResult>();

            if (!Validator.TryValidateObject(user, contexto, resultados, true))
            {
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();


        }
    }
}
