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
        Name = name.Trim();
        Surname = surname.Trim();
        Street = street.Trim();
        City = city.Trim();
        Province = province.Trim();
        Zip = zip.Trim();
    }

    public void Print()
    {
        //Console.WriteLine(this.Name);
        //Console.WriteLine(this.Surname);
        //Console.WriteLine(this.Street);
        //Console.WriteLine(this.City);
        //Console.WriteLine(this.Province);
        //Console.WriteLine(this.Zip);

        Console.WriteLine( $"------Address------\n" +
                                $"Name:\t\t{this.Name}\n" +
                                $"Surname:\t{this.Surname}\n" +
                                $"Street:\t\t{this.Street}\n" +
                                $"City:\t\t{this.City}\n" +
                                $"Province:\t{this.Province}\n" +
                                $"ZIP:\t\t{this.Zip}\n" +
                                "-------------------\n");
    }
}