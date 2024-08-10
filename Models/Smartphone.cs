namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private readonly string _modelo;
        private readonly string _imei;
        private readonly int _memoria;

        public string Numero { get; set; }

        private string Modelo
        {
            get { return _modelo; }
        }

        private string Imei
        {
            get { return _imei; }
        }

        private int Memoria
        {
            get { return _memoria; }
        }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void ExibirInformacoes()
        {
            Console.WriteLine("# Informações sobre o Smartphone:");
            Console.WriteLine($"# Número: {Numero}");
            Console.WriteLine($"# Modelo: {Modelo}");
            Console.WriteLine($"# IMEI: {Imei}");
            Console.WriteLine($"# Memória: {Memoria}GB");
        }
    }
}