namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo{ get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama


        public Smartphone(string numero) => Numero = numero;

        // TODO: Passar os parâmetros do construtor para as propriedades

        protected string modelo;
        public void ModeloSmartphone  (string modelo)
        {
            Modelo = modelo;
        }

        protected string imei;

        public void Imei (string imei)
        {
            IMEI = imei;
        }

        protected int memoria;

    public void MemoriaSmartphone(int memoria)
    {
            Memoria = memoria;
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
    }
}