using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone i = new Iphone("81 987366959");
i.ModeloSmartphone("Iphone Pro MAX 14");
i.Imei("Aleatorio 1234");
i.MemoriaSmartphone(128);


Nokia n = new Nokia("11-987366959");
n.ModeloSmartphone("Nokia Tijolão");
n.Imei("Aleatorio 9876");
n.MemoriaSmartphone(8);




i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Whatsapp");

Console.WriteLine($" \n trocando para {n.Numero} \n" );

n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Telegram");

