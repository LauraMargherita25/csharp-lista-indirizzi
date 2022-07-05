// See https://aka.ms/new-console-template for more information


StreamReader file = File.OpenText("C:/Users/windo/corso .NET/repos/csharp-lista-indirizzi/addresses.csv");

List<Address> addresses = new List<Address>();
while (!file.EndOfStream)
{

    try
    {
        string line = file.ReadLine();
        string[] addressData = new string[6];
        addressData = line.Split(",");

        if(addressData.Length > 6)
        {
            throw new IndexOutOfRangeException();
        }

        Address newAddress = new Address(addressData[0], addressData[1], addressData[2], addressData[3], addressData[4], addressData[5]);

        addresses.Add(newAddress);

    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Stai cercando di inserire più elementi di quelli che l'array può contenere");
        if ()
        {

        }
    }
}
file.Close();

foreach (Address address in addresses)
{
    address.Print();
}