using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone1 = new Iphone("31 912344321", "Iphone 14", "123456789123456", 128 );
Nokia nokia1 = new Nokia("31 912344321", "Nokia 3310", "123456789123456", 8);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Youtube");

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Jogo da cobrinha");

