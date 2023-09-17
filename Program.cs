using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "17 9-9999-9999", modelo:"Nokia C30", imei: "12897373939", memoria:128);
nokia.ModeloAparelho();
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Smartphone iphone = new Iphone(numero: "17 9-9888-8888", modelo:"Iphone 14", imei: "122972323939", memoria:256);
iphone.ModeloAparelho();
iphone.Ligar();
iphone.InstalarAplicativo("Pintrest");
