using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "222222222", "3333333333", 4);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("123456", "222222222", "3333333333", 4);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
