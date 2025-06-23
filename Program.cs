using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia("11999999999", "Nokia X20", "123456789", 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\nSmartphone iPhone:");
var iphone = new Iphone("11988888888", "iPhone 13", "987654321", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");