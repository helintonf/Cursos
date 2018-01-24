using System;
using Lib;
using Newtonsoft.Json;
using System.IO;

namespace SerializarDeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Console.ReadKey();
        }

        /// <summary>
        /// Serializar um objeto em JSON
        /// </summary>
        static void Serializar()
        {
            Usuario user = new Usuario() { Nome = "Josielly Fioramonte", Email = "josiellyjf@gmail.com", CPF = "321654987" };

            string json = JsonConvert.SerializeObject(user);

            StreamWriter sw = new StreamWriter("C:\\home\\SerializarJSON.json");

            sw.WriteLine(json);

            sw.Close();
        }


        static void Deserializar()
        {
            StreamReader sr = new StreamReader("C:\\home\\SerializarJSON.json");

            Usuario user = (Usuario)JsonConvert.DeserializeObject(sr.ReadToEnd(), typeof(Usuario));

            Console.WriteLine($"Usuario: \nNome: {user.Nome}\nEmail: {user.Email}\nCPF: {user.CPF}");
        }
    }
}
