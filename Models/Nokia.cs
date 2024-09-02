namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor que chama o construtor da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...\n");
        }
    }
}
