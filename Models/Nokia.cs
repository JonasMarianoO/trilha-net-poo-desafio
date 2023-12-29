namespace DesafioPOO.Models
{
    //Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
        // Implementação do método na classe derivada
        Console.WriteLine($"Baixando {nomeApp}!");
        }   
    }
}