using System;

class Program
{
    public static void Main()
    {
        Address address = new Address();
        address.SetIndex(123);
        address.SetCity("Kyiv");
        address.SetHouse(123);
        address.SetApartment(123);
        address.SetCountry("Ukraine");

        Console.WriteLine(address);
    }
}