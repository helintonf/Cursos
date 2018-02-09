using Reflections.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections
{
    class LogNormal
    {
        public static List<Usuario> users = new List<Usuario>();
        public static List<Carro> cars = new List<Carro>();
        public static void GravarUser(Usuario user)
        {
            users.Add((Usuario)user.Clone());
        }

        public static void GravarCar(Carro car)
        {
            cars.Add(car);
        }

        public static void ApresentarLog()
        {
            foreach (Usuario user in users)
            {
                Console.WriteLine($"Nome: {user.Nome}, Email: {user.Email}, Senha: {user.Senha}");
            }

            foreach (Carro car in cars)
            {
                Console.WriteLine($"Marca: {car.Marca}, Modelo: {car.Modelo}");
            }
        }
    }

    public class Log
    {
        public static List<Object> objetos = new List<object>();

        public static void Gravar(object obj)
        {
            objetos.Add(obj);
        }

        public static void Apresentar()
        {
            foreach(object obj in objetos)
            {
                Console.WriteLine($"-----------Classe: {obj.GetType().Name}------------");//pegar nome classe

                foreach(var prop in obj.GetType().GetProperties()) //pegar as propriedades
                {
                    Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
                }

            }
        }

    }
}
