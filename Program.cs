using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone1 = new Iphone("5941022","16 Pro", "sadsdasdas",256);
iphone1.InstalarAplicativo("Telegram");
iphone1.Ligar();
iphone1.ReceberLigacao();

Nokia nokia1 = new Nokia("1235148","Tijolão", "sadsdasdas",1080);
nokia1.InstalarAplicativo("Orkut");
nokia1.Ligar();
nokia1.ReceberLigacao();
