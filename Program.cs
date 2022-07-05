// See https://aka.ms/new-console-template for more information


StreamReader file = File.OpenText("C:/Users/windo/corso .NET/repos/csharp-lista-indirizzi/addresses.csv");

while (!file.EndOfStream)
{
    List<Address> data = new List<Address>();
    //string line = file.ReadLine();
    //string[] row = new string[6];
    //row = line.Split(",");
    //string newLine = line.Replace(",", ", ");
    

    //foreach (string lineSplited in newLineSplited)
    //{
    //    Console.WriteLine(lineSplited);
    //    Console.WriteLine();
    //}



    //string line = file.ReadLine();
    //    Console.WriteLine(newLineSplited);

    string rows = file.ReadLine();
    string[] address = new string[6];
    address = rows.Split(",");

    for(int i = 0; i < address.Length; i++)
    {
        foreach(string data in address)
        {
            Address.Name = address[0];
            Address.Surname = address[1];
            Address.Street = address[2];
            Address.City = address[3];
            Address.Province = address[4];
            Address.Zip = address[6];

            Address newAddress = new Address();

        }
    }




}
file.Close();
