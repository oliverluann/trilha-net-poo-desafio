using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11980808080", modelo: "Modelo N1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "11945454545", modelo: "Modelo iP1", imei: "22222222", memoria: 64);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");