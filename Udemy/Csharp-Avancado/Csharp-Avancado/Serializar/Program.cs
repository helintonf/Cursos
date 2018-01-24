using System;
//serealizar
using System.IO;
using Lib;
using System.Xml.Serialization;

namespace Serializar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Deserializar();

            Console.ReadKey();
        }

        /// <summary>
        /// serializar um objeto para XML
        /// </summary>
        static void Serializar()
        {
            Usuario user = new Usuario() { Nome = "Helinton", Email = "helintongi@gmail.com", CPF = "32565083831" };


            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(user.GetType());

            StreamWriter str = new StreamWriter("C:\\home\\Serializar.xml");

            serializador.Serialize(str, user);
        }

        /// <summary>
        /// Deserializar XML para um objeto
        /// </summary>
        static void Deserializar()
        {
            StreamReader str = new StreamReader("C:\\home\\Serializar.xml");

            XmlSerializer deserializador = new XmlSerializer(typeof(Usuario));

            Usuario user = (Usuario)deserializador.Deserialize(str);

            Console.WriteLine($"Usuario: \n     Nome: {user.Nome} \n    Email: {user.Email} \n      CPF: {user.CPF}");
        }
    }
}
