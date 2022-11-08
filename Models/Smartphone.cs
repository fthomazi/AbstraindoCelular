namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando chamada de emergencia");
        }
        public void Ligar(string numero)
        {
            Console.WriteLine("Ligando para " + numero);
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            for(int i=0; i<Numero.Length; i++)
                Console.Beep();
            Console.WriteLine("Chamada perdida!");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}