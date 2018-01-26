using Generics.Lib;
using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Carro car = new Carro() { Marca = "Audio", Modelo = "A4" };
            Casa casa = new Casa() { Cidade = "Araras", Endereco = "Rua Pernambuco" };
            Usuario user = new Usuario() { Nome = "Helinton", Email = "helintonfi@gmail.com", Senha = "128914" };


            Serializador.Serializar(car);
            Serializador.Serializar(casa);
            Serializador.Serializar(user);


            Carro car2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario user2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: " + car2.Marca + " - " + car2.Modelo);
            Console.WriteLine("Casa2: " + casa2.Cidade + " - " + casa2.Endereco);
            Console.WriteLine("User2: " + user2.Nome + " - " + user2.Email +" - " + user2.Senha);

            Console.ReadKey();
        }
    }
}
