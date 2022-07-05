// See https://aka.ms/new-console-template for more information


internal class Address
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }    
    public string Province { get; set; }
    public string Zip { get; set; }

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public void Print()
    {
        Console.WriteLine(this.Name);
        Console.WriteLine(this.Surname);
        Console.WriteLine(this.Street);
        Console.WriteLine(this.City);
        Console.WriteLine(this.Province);
        Console.WriteLine(this.Zip);
    }
}