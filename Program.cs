// See https://aka.ms/new-console-template for more information


StreamReader file = File.OpenText("C:/Users/windo/corso .NET/repos/csharp-lista-indirizzi/addresses.csv");

List<Address> addresses = new List<Address>();
while (!file.EndOfStream)
{
    string line;
    string[] addressData = new string[6];
    try
    {
        line = file.ReadLine();
        addressData = line.Split(",");

        if(addressData.Length > 6)
        {
            throw new BedFormat();
        }

        if (addressData.Length < 6) 
        {
            throw new BedFormat();
        }

            Address newAddress = new Address(addressData[0], addressData[1], addressData[2], addressData[3], addressData[4], addressData[5]);

        
        addresses.Add(newAddress);

        

    }
    catch (BedFormat e)
    {
        e.ToManyOrNotEnoughElements();

        Console.WriteLine();

        for(int i = 0; i < addressData.Length; i++)
        {
            Console.WriteLine("{0}. {1}",i + 1, addressData[i]);
        }

        Console.WriteLine("Reinserisci i dati");
        string[] modifiedAddressData = new string[6];
        for(int i = 0; i < modifiedAddressData.Length; i++)
        {
            Console.Write($"{i + 1}. ");
            modifiedAddressData[i] = Console.ReadLine();
        
        }

        Address newAddress = new Address(modifiedAddressData[0], modifiedAddressData[1], modifiedAddressData[2], modifiedAddressData[3], modifiedAddressData[4], modifiedAddressData[5]);

        addresses.Add(newAddress);
    }
}
file.Close();

foreach (Address address in addresses)
{
    address.Print();

    Console.WriteLine();
}