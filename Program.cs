using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Iphone:");
Iphone i1 = new Iphone(numero: "22222222", modelo: "Iphone 15", imei: "1111111", memoria: 128);
i1.Ligar();
i1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Celular Nokia:");
Nokia n1 = new Nokia(numero: "111111111", modelo: "Tijolão", imei: "22222222", memoria: 2);
n1.Ligar();
n1.InstalarAplicativo("Sudoku");
