namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private readonly string _modelo;
        private readonly string _imei;
        private readonly int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar() => Console.WriteLine("Ligando...");
        public void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
