using DesafioPOO.Models;

//Realizando os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"1234565", modelo:"MODELO 1", imei:"111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"543215", modelo:"MODELO 2", imei:"222222222222", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Netflix");