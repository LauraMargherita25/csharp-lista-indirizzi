﻿// See https://aka.ms/new-console-template for more information


StreamReader file = File.OpenText("C:/Users/windo/corso .NET/repos/csharp-lista-indirizzi/addresses.csv");

while (!file.EndOfStream)
{

    string line = file.ReadLine();

    //string line = file.ReadLine();
    //Console.WriteLine(line);
}
file.Close();

//string path = ".C:/Users/windo/corso.NET/repos/csharp-lista-indirizzi/addresses.csv";
//if (!File.Exists(path))
//{
//    // Creo un file
//    StreamWriter file = File.CreateText(path);
//    //scrivo le mie linee di testo
//    file.WriteLine("Hello");
//    file.WriteLine("And");
//    file.WriteLine("Welcome");
//    //chiudo il mio file
//    file.Close();
//}