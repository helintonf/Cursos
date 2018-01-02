
namespace Classe.Veiculo
{
    class Carro
    {
        //propriedades
        public string Marca = "FIAT";
        public string Modelo;
        public string Cor;
        public bool LuzInterna = false;
        
        //metodos
        public void AbrirPorta()
        {
            LuzInterna = true;
        }

        public void FecharPorta()
        {
            LuzInterna = false;
        }

        public string AcenderFarolAutomaticamente()
        {
            return "Médio";
        }

    }
}
