using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Calculation__easy
{
    class Program
    {
        const decimal valueUSDBYN = 0.3818m, valueEURBYN = 0.315m, valueRUBBYN = 0.0347m;
        const decimal valueEURUSD = 0.8252m, valueEURRUB = 0.0109m, valueUSDRUB = 0.0132m;
        const string txtMessage = "Please, enter from what currency exchage(BYN, USD, EUR, RUB)";
        static void Main(string[] args)
        {
            {
                Console.Title = "Dmitry Salata-TMS.Net07.Homework - easy";
                decimal exchangeValue, outputExchange;
                string fromCurrency, toCurrency;
                bool fromCurrencyIsOk, toCurrencyIsOk, checkExchangeValue;

                Console.WriteLine($"{txtMessage}:");
                fromCurrency = Console.ReadLine().ToLower();
                //exit from program
                for (; !fromCurrency.Equals("exit") ; Console.WriteLine($"{txtMessage} or exit for closing program:"), fromCurrency = Console.ReadLine())
                {
                    //check for input. if input is not correct cycle "for" use.
                    fromCurrencyIsOk = fromCurrency.Equals("usd") || fromCurrency.Equals("eur") || fromCurrency.Equals("rub") || fromCurrency.Equals("byn");

                    for (; fromCurrencyIsOk != true; fromCurrency = Console.ReadLine().ToLower(), fromCurrencyIsOk = fromCurrency.Equals("usd") || fromCurrency.Equals("eur") || fromCurrency.Equals("rub") || fromCurrency.Equals("byn"))
                    {
                        Console.WriteLine("Check your input. Enter currency in format BYN, USD, EUR, RUB:");
                    }

                    Console.WriteLine("Please, enter to what currency exchage (BYN, USD, EUR, RUB):");
                    toCurrency = Console.ReadLine().ToLower();
                    toCurrencyIsOk = toCurrency.Equals("usd") || toCurrency.Equals("eur") || toCurrency.Equals("rub") || toCurrency.Equals("byn");

                    for (;toCurrencyIsOk != true; toCurrency = Console.ReadLine().ToLower(), toCurrencyIsOk = toCurrency.Equals("usd") || toCurrency.Equals("eur") || toCurrency.Equals("rub") || toCurrency.Equals("byn")) 
                    {
                        Console.WriteLine("Check your input. Enter currency in format BYN, USD, EUR, RUB:");
                    }

                    Console.WriteLine("Please, enter exchanging amount:");
                    checkExchangeValue = decimal.TryParse(Console.ReadLine(), out exchangeValue);

                    for (; checkExchangeValue != true; checkExchangeValue = decimal.TryParse(Console.ReadLine(), out exchangeValue)) 
                    {
                        Console.WriteLine("Check your enter. Value can be only a number:");
                    }

                    if (fromCurrency == "usd")
                    {

                        switch (toCurrency)
                        {
                            case ("byn"):
                                outputExchange = valueUSDBYN * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("eur"):
                                outputExchange = valueEURUSD / exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("rub"):
                                outputExchange = valueUSDRUB * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            default:
                                Console.WriteLine($"Check your enter. Exchange value enter in format eur, usd, rub, byn. Value of exchange currency may be only a number.");
                                break;
                        }
                    }

                    else if (fromCurrency == "byn")
                    {
                        switch (toCurrency)
                        {
                            case ("usd"):
                                outputExchange = valueUSDBYN * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("eur"):
                                outputExchange = valueEURBYN * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("rub"):
                                outputExchange = valueRUBBYN / exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;
                            
                            default:
                                Console.WriteLine($"Check your enter. Exchange value enter in format eur, usd, rub, byn. Value of exchange currency may be only a number.");
                                break;
                        }

                    }

                    else if (fromCurrency == "eur")
                    {
                        switch (toCurrency)
                        {
                            case ("usd"):
                                outputExchange = valueEURUSD * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("byn"):
                                outputExchange = valueEURBYN * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("rub"):
                                outputExchange = valueEURRUB * exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            default:
                                Console.WriteLine($"Check your enter. Exchange value enter in format eur, usd, rub, byn. Value of exchange currency may be only a number.");
                                break;
                        }
                    }

                    //to RUB
                    else
                    {
                        switch (toCurrency)
                        {
                            case ("usd"):
                                outputExchange = valueUSDRUB / exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("byn"):
                                outputExchange = valueRUBBYN / exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            case ("eur"):
                                outputExchange = valueEURRUB / exchangeValue;
                                Console.WriteLine($"{exchangeValue} {fromCurrency} equal to {outputExchange} {toCurrency}");
                                break;

                            default:
                                Console.WriteLine($"Check your enter. Exchange value enter in format eur, usd, rub, byn. Value of exchange currency may be only a number.");
                                break;
                        }
                    }
                }
            }
        }
    }
}
