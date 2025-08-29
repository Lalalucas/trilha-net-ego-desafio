using DesafioPOO.Models;

Console.WriteLine("--- Teste com Smartphone Nokia ---");
Smartphone nokia = new Nokia(numero: "11987654321", modelo: "Nokia G21", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-----------------------------------\n");

Console.WriteLine("--- Teste com Smartphone iPhone ---");
Smartphone iphone = new Iphone(numero: "21912345678", modelo: "iPhone 14 Pro", imei: "222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
