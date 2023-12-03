using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Address
{

    public int Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public int House { get; set; }
    public int Apartment { get; set; }

    public override string? ToString()
    {
        return $"{Index}, {Country}, {City}, {House}, {Apartment}";
    }

}
