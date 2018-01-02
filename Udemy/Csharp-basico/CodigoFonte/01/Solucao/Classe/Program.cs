using System;
using Classe.Veiculo;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Classe.Veiculo.Carro car1 = new Carro(); // caminho absoluto
            Veiculo.Carro car2 = new Carro(); //caminho relativo
            Carro car3 = new Carro(); //caminho importado
            Moto mot = new Moto();
            Aviao av = new Aviao();
           
            Console.WriteLine("Marca: "+car1.Marca);

            car1.Marca = "Ford";

            Console.WriteLine("Marca: " + car1.Marca);


            Console.WriteLine("Luz Interna: " + car1.LuzInterna);
            car1.AbrirPorta();
            Console.WriteLine("Luz Interna: " + car1.LuzInterna);




            string statusFarol = car1.AcenderFarolAutomaticamente();

            Console.WriteLine("Status Farol: " + statusFarol);





            Console.ReadKey();
        }
    }
}
