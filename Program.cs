using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 1", imei: "I11111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("NokiaTalks");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "778899", modelo: "Iphone 1", imei: "I9987987", memoria: 284);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ContactDirectly");