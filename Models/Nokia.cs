namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public  Nokia(string numero, string modelo, String imei, int memoria): base(numero, modelo,imei,memoria){
              Numero = numero;
              Modelo = modelo;
              IMEI = imei;
              Memoria = memoria;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine("Você está instalando o app "+ nomeApp + " no seu Nokia de número " + Numero + ", modelo "+ Modelo + ", Imei " + IMEI + " e quatidade de memória igual a " + Memoria + "GB");
        }
    }
}