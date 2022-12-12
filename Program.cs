using DesafioPOO.Models;

// (** IMPLEMENTADO **)
Console.WriteLine("Smarthphone Nokia.");
Smartphone nokia = new Nokia("899999999", "Nokia Tijolão", "123456/00/987654/1", 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone IPhone.");
Smartphone iphone = new Iphone("999999999", "IPhone G3", "01 234567 890123 4", 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Netflix");