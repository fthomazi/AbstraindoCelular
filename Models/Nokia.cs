using System;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
            Numero = numero;          
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (!string.IsNullOrEmpty(nomeApp))
            {
                Console.WriteLine("Aguarde...");
                Console.WriteLine("O App " + nomeApp + " foi instalado");
            }                
            else
            {
                Console.WriteLine("Nome de app invalido. Digite novamente");
                InstalarAplicativo(Console.ReadLine());
            }
        }
    }
}