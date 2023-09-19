using Lab3._1;
Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] engineInfo = Console.ReadLine().Split();
    string model = engineInfo[0];
    int power = int.Parse(engineInfo[1]);
    double? displacement = engineInfo.Length > 2 ? double.Parse(engineInfo[2]) : (double?)null;
    string efficiency = engineInfo.Length > 3 ? engineInfo[3] : "n/a";

    Engine engine = new Engine(model, power, displacement, efficiency);
    engines[model] = engine;
}

int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    string[] carInfo = Console.ReadLine().Split();
    string model = carInfo[0];
    string engineModel = carInfo[1];
    Engine engine = engines[engineModel];
    double? weight = carInfo.Length > 2 && double.TryParse(carInfo[2], out var carWeight) ? double.Parse(carInfo[2]) : (double?)null;
    
    string color = carInfo.Length > 3 ? carInfo[3] : "n/a";

    Car car = new Car(model, engine, weight, color);

    Console.WriteLine($"{car.Model}:");
    Console.WriteLine($"  {car.Engine.Model}:");
    Console.WriteLine($"    Power: {car.Engine.Power}");
    Console.WriteLine($"    Displacement: {car.Engine.Displacement ?? -1}");
    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
    Console.WriteLine($"  Weight: {car.Weight }");
    Console.WriteLine($"  Color: {car.Color}");
}
