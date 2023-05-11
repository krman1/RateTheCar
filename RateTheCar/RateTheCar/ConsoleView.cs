using System;
using System.Runtime.CompilerServices;

namespace RateTheCar
{
    public class ConsoleView
    {
        public void Run()
        {
            Console.WriteLine("Witamy w programie RateTheCar do oceny samochodów");
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("1 - Dodoać oceny samochodu i zapisać w pamięci");
            Console.WriteLine("2 - Dodoać oceny samochodu i zapisać do pliku");
            Console.WriteLine("3 - Zakończyć program");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CarInMemory carInMemory = new CarInMemory();
                    carInMemory.CreateCar();
                    while (true)
                    {
                        Console.WriteLine($"Podaj kolejną ocenę smochodu {carInMemory.Brand} {carInMemory.Model} w zakresie 0 - 10 lub q jesli chesz zakończyć");
                        var input = Console.ReadLine();
                        if (input == "q")
                        {
                            break;
                        }
                        try
                        {
                            carInMemory.AddScore(input);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Exeption catched: {e.Message}");
                        }
                    }
                    var statistics = carInMemory.GetStatistics();
                    Console.WriteLine($"Average: {statistics.Average}");
                    Console.WriteLine($"Min: {statistics.Min}");
                    Console.WriteLine($"Max: {statistics.Max}");
                    Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
                    break;

                case "2":
                    CarInFile carInFile = new CarInFile();
                    carInFile.CreateCar();
                    while (true)
                    {
                        Console.WriteLine($"Podaj kolejną ocenę smochodu {carInFile.Brand} {carInFile.Model} w zakresie 0 - 10 lub q jesli chesz zakończyć");
                        var input = Console.ReadLine();
                        if (input == "q")
                        {
                            break;
                        }
                        try
                        {
                            carInFile.AddScore(input);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Exeption catched: {e.Message}");
                        }
                    }
                    var statistics1 = carInFile.GetStatistics();
                    Console.WriteLine($"Average: {statistics1.Average}");
                    Console.WriteLine($"Min: {statistics1.Min}");
                    Console.WriteLine($"Max: {statistics1.Max}");
                    Console.WriteLine($"AverageLetter: {statistics1.AverageLetter}");
                    break;

                case "3":
                    Console.WriteLine("Do zobaczenia");
                    break;
                default:
                    Console.WriteLine("Zły wybór zacznijmy od nowa");
                    Run();
                    break; 
            }
        }
    }
}

