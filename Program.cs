// See https://aka.ms/new-console-template for more information


StreamReader file = File.OpenText("C:/Users/windo/corso .NET/repos/csharp-lista-indirizzi/addresses.csv");

while (!file.EndOfStream)
{
    List<DataItem> data = new List<DataItem>();
    string line = file.ReadLine();
    //line.Split(",");
    string newLine = line.Replace(",", ", ");
    foreach(new)
    newLine.Split(", ");

    //string line = file.ReadLine();
    Console.WriteLine(newLine);
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