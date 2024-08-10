using DesafioPOO.Models;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("# Smartphone Iphone:");
Iphone iphone = new Iphone("123456789", "iPhone 1", "1111111111", 128);
iphone.ExibirInformacoes();

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine();

// A única propriedade possível de ser alterada fora do construtor é o Número.
iphone.Numero = "123-456-789";
// iphone.Modelo = "iPhone 2";
// iphone.Imei = "3333333333";
// iphone.Memoria = 256;
iphone.ExibirInformacoes();

Console.WriteLine();
Console.WriteLine();

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("987654321", "Nokia 1", "222222222222", 64);
nokia.ExibirInformacoes();

Console.WriteLine();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

nokia.Numero = "987-654-321";
nokia.ExibirInformacoes();
Console.ResetColor();
