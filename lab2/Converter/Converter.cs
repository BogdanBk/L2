using System;

class CurrencyConverter
{
    private double usdExchangeRate;
    private double eurExchangeRate;
    private double plnExchangeRate;

    public CurrencyConverter(double usd, double eur, double pln)
    {
        usdExchangeRate = usd;
        eurExchangeRate = eur;
        plnExchangeRate = pln;
    }

    public char GetUserChoiceFirst()
    {
        char input;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Enter your choice");
            Console.WriteLine("A - From UAH to USD, EUR, PLN");
            Console.WriteLine("B - From USD, EUR, PLN to UAH");
            Console.WriteLine("E - Exit");
            Console.Write("A, B, E: ");
            input = char.Parse(Console.ReadLine());
        } while (input != 'A' && input != 'a' && input != 'B' && input != 'b' && input != 'E' && input != 'e');

        return input;
    }

    public void HandleUserChoiceSecond(char input)
    {
        switch (input)
        {
            case 'A':
            case 'a':
                Console.WriteLine("Choose currency");
                Console.WriteLine("1 - UAH > USD");
                Console.WriteLine("2 - UAH > EUR");
                Console.WriteLine("3 - UAH > PLN");
                Console.WriteLine("4 - Back");
                int currencyChoice = int.Parse(Console.ReadLine());
                if (currencyChoice == 4)
                {
                    break;
                }
                double convertedAmount = 0.0;
                Console.WriteLine($"Enter how much do you want to convert: ");
                double uahAmount = double.Parse(Console.ReadLine());
                switch (currencyChoice)
                {
                    case 1:
                        convertedAmount = uahAmount / usdExchangeRate;
                        Console.WriteLine($"Converted amount: {convertedAmount} USD. With the dollar exchange rate of {usdExchangeRate}");
                        break;
                    case 2:
                        convertedAmount = uahAmount / eurExchangeRate;
                        Console.WriteLine($"Converted amount: {convertedAmount} EUR. With the euro exchange rate of {eurExchangeRate}");
                        break;
                    case 3:
                        convertedAmount = uahAmount / plnExchangeRate;
                        Console.WriteLine($"Converted amount: {convertedAmount} PLN. With the zloty exchange rate of {plnExchangeRate}");
                        break;
                    default:
                        Console.WriteLine("Error in currency choice.");
                        break;
                }
                break;
            case 'B':
            case 'b':
                Console.WriteLine("Choose currency");
                Console.WriteLine("1 - USD > UAH");
                Console.WriteLine("2 - EUR > UAH");
                Console.WriteLine("3 - PLN > UAH");
                Console.WriteLine("4 - Back");
                int currencyChoiceSecond = int.Parse(Console.ReadLine());
                if (currencyChoiceSecond == 4)
                {
                    break;
                }
                double convertedAmountSecond = 0.0;
                Console.WriteLine($"Enter how much do you want to convert: ");
                double uahAmountSecond = double.Parse(Console.ReadLine());

                switch (currencyChoiceSecond)
                {
                    case 1:
                        convertedAmount = usdExchangeRate * uahAmountSecond;
                        Console.WriteLine($"Converted amount: {convertedAmount} USD. With the dollar exchange rate of {usdExchangeRate}");
                        break;
                    case 2:
                        convertedAmount = eurExchangeRate * uahAmountSecond;
                        Console.WriteLine($"Converted amount: {convertedAmount} EUR. With the euro exchange rate of {eurExchangeRate}");
                        break;
                    case 3:
                        convertedAmount = plnExchangeRate * uahAmountSecond;
                        Console.WriteLine($"Converted amount: {convertedAmount} PLN. With the zloty exchange rate of {plnExchangeRate}");
                        break;
                    default:
                        Console.WriteLine("Error in currency choice.");
                        break;
                }
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CurrencyConverter currencyConverter = new CurrencyConverter(27.50, 31.00, 6.50);

        char userChoiceFirst;
        do
        {
            userChoiceFirst = currencyConverter.GetUserChoiceFirst();
            currencyConverter.HandleUserChoiceSecond(userChoiceFirst);

        } while (userChoiceFirst != 'E' && userChoiceFirst != 'e');
    }
}
