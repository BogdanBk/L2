using System;

class Program
{
    private const double usd = 36.95;
    private const double eur = 39.64;
    private const double pln = 8.54;

    public static void Main()
    {
        Converter converter = new Converter(usd, eur, pln);
        char currency;
        start:
        do
        {
            currency = converter.UserCurrencyChoice();
        } while (currency != '1' && currency !='2' && currency !='3');
        do
        {
            if (currency == '1')
            {

                Console.WriteLine();
                char choice;
                choice = converter.UserChoiceFromUAH();
                switch (choice)
                {
                    case '1':
                    case '2':
                    case '3':
                        converter.UserConvertFromUAH(choice); break;
                    case '4': goto start;
                    default: continue;
                }

            }
            else if (currency == '2')
            {
                Console.WriteLine();
                char choice;
                choice = converter.UserChoiceFromForeign();
                switch (choice)
                {
                    case '1':
                    case '2':
                    case '3':
                        converter.UserConvertFromForeign(choice); break;
                    case '4': goto start;
                    default: continue;
                }
            }
            else if (currency == '3')
            {
                Console.WriteLine("\n" +
                                  "Exiting...");
                return;
            }
            else
            {
                Console.WriteLine("Something went wrong in currency choosing, please try again");
                return;
            }
        } while (currency != '3');
    }
}