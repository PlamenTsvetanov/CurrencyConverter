using System;

class CurrencyConverter
{
    static void Main(string[] args)
    {
        var usd = 1.79549;
        var eur = 1.95583;
        var gbp = 2.53405;
        var bg = "BGN";
        var eu = "EUR";
        var gb = "GBP";
        var us = "USD";
        
        Console.Write("Enter the sum: ");
        var money = Convert.ToDouble(Console.ReadLine()); 
        Console.Write("Enter currency for input: ");
        var currencyForInput = Console.ReadLine();
        Console.Write(" Enter currency for output:  ");
        var currencyForOutput = Console.ReadLine();
        if (currencyForInput == us)
        {
            if (currencyForOutput == bg)
            {
                Console.WriteLine(Math.Round( money*usd,2));
            }
        }
        if (currencyForInput == bg)
        {
            if (currencyForOutput == eu)
            {
                Console.WriteLine(Math.Round(money/eur,2));
            }
        }
        if (currencyForInput == eu)
        {
            if (currencyForOutput == gb)
            {
                Console.WriteLine(Math.Round(money* (eur/gbp),2));
            }
        }

        if (currencyForInput == us)
        {
            if(currencyForOutput == eu)
            {
                Console.WriteLine(Math.Round(money*(usd/eur),2));
            }
        }
        if (currencyForInput == gb)
        {
            if(currencyForOutput == us)
            {
                Console.WriteLine(Math.Round(money*(gbp/usd),2));
            }
        }
    }


}


