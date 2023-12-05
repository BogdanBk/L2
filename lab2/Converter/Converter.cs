using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln) 
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public char UserCurrencyChoice()
    {
        Console.WriteLine("\n" +
                          "Enter your choice\n" +
                          "1 - From UAH to USD, EUR, PLN\n" +
                          "2 - From USD, EUR, PLN to UAH\n" +
                          "3 - Exit");
        Console.Write("Choice: ");
        char input = Console.ReadKey().KeyChar;

        return input;
    }

    public char UserChoiceFromUAH()
    {
        Console.WriteLine("\n" +
                          "Choose currency\n" +
                          "1 - UAH > USD\n" +
                          "2 - UAH > EUR\n" +
                          "3 - UAH > PLN\n" +
                          "4 - Back");
        Console.Write("Choice: ");
        char input = Console.ReadKey().KeyChar;
        return input;

    }
    public void UserConvertFromUAH(char input)
    {
        double convertedAmount = 0.0;
        double uahAmount;
        try
        {
            Console.WriteLine("\n" +
                              "Enter how much do you want to convert: ");
            uahAmount = double.Parse((Console.ReadLine()));
        } catch (FormatException) { Console.WriteLine("Invalid input"); return; }
        switch (input)
        {
            case '1':
                convertedAmount = uahAmount / usd;
                Console.WriteLine($"Converted amount: {convertedAmount} USD. With the dollar exchange rate of {usd}");
                break;
            case '2':
                convertedAmount = uahAmount / eur;
                Console.WriteLine($"Converted amount: {convertedAmount} EUR. With the euro exchange rate of {eur}");
                break;
            case '3':
                convertedAmount = uahAmount / pln;
                Console.WriteLine($"Converted amount: {convertedAmount} PLN. With the zloty exchange rate of {pln}");
                break;
            default:
                Console.WriteLine("Error in currency choice.");
                break;
        }
    }
    public char UserChoiceFromForeign()
    {
        Console.WriteLine("\n" +
                          "Choose currency\n" +
                          "1 - USD > UAH\n" +
                          "2 - EUR > UAH\n" +
                          "3 - PLN > UAH\n" +
                          "4 - Back");
        Console.Write("Choice: ");
        char input = Console.ReadKey().KeyChar;
        return input;
    }

    public void UserConvertFromForeign(char input)
    {
        double convertedAmount = 0.0;
        double uahAmountSecond;
        try
        {
            Console.WriteLine("\n" +
                              "Enter how much do you want to convert: ");
            uahAmountSecond = double.Parse(Console.ReadLine());
        } catch (FormatException) { Console.WriteLine("Invalid input"); return; }

        switch (input)
        {
            case '1':
                convertedAmount = usd * uahAmountSecond;
                Console.WriteLine($"Converted amount: {convertedAmount} UAH. With the dollar exchange rate of {usd}");
                break;
            case '2':
                convertedAmount = eur * uahAmountSecond;
                Console.WriteLine($"Converted amount: {convertedAmount} UAH. With the euro exchange rate of {eur}");
                break;
            case '3':
                convertedAmount = pln * uahAmountSecond;
                Console.WriteLine($"Converted amount: {convertedAmount} UAH. With the zloty exchange rate of {pln}");
                break;
            default:
                Console.WriteLine("Error in currency choice.");
                break;
        }
    }
    

}
