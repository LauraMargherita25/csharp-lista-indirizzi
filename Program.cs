// See https://aka.ms/new-console-template for more information


StreamReader file = File.OpenText("C:/Users/windo/corso .NET/repos/csharp-lista-indirizzi/addresses.csv");

while (!file.EndOfStream)
{
    List<Address> addresses = new List<Address>();
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
        for(int j = 0; j < address.Length; j++)
        {
            Address newAddress = new Address();

            newAddress.Name = address[0];
            newAddress.Surname = address[1];
            newAddress.Street = address[2];
            newAddress.City = address[3];
            newAddress.Province = address[4];
            newAddress.Zip = address[6];

            addresses.Add(newAddress);
        }
    }




}
file.Close();
