// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Televisao tv = new Televisao(60f);


Console.WriteLine($"A tv tem o tamanho {tv.Tamanho}");

tv.Volume = -35;
Console.WriteLine($"Volume {tv.Volume}");

tv.Volume = 100;
Console.WriteLine($"Volume {tv.Volume}");



