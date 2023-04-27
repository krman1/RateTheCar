using RateTheCar;

Console.WriteLine("Witamy w programie RateTheCar do oceny samochodów");
Console.WriteLine("=============================================");
Console.WriteLine();


var car = new CarInMemory("Mazda", "CX5");


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę smochodu w zakresie 0 - 10 lub q jesli chesz zakończyć");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {

        car.AddScore(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}


var statistics = car.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");

