
using Lab3;
using Lab3.Task8;
using System.Globalization;
using System.Xml.Linq;


int option= int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        Family family = new Family();


        Console.Write("Enter the number of family members: ");
        int n = int.Parse(Console.ReadLine());



        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (input.Length != 2)
            {
                Console.WriteLine("Invalid input format");
                return;
            }

            string name = input[0];
            int age;
            if (!int.TryParse(input[1], out age))
            {
                Console.WriteLine("Invalid age format");
                return;
            }

            Person person = new Person(name, age);
            family.AddMember(person);
        }

        Person oldestMember = family.GetOldestMember();
        if (oldestMember != null)
        {

            Console.WriteLine(oldestMember.Age);
        }
        else
        {
            Console.WriteLine("No family members.");
        }

        break;

        case 2:
        
        Dictionary<string, List<Employee>> employeesByDepartment = new Dictionary<string, List<Employee>>();

        int n2 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n2; i++)
        {
            string[] employeeInfo = Console.ReadLine().Split();
            string name = employeeInfo[0];
            decimal salary = decimal.Parse(employeeInfo[1], CultureInfo.InvariantCulture);
            string position = employeeInfo[2];
            string department = employeeInfo[3];
            string email = "n/a";
            int age = -1;

            if (employeeInfo.Length > 4)
            {
                if (employeeInfo[4].Contains('@'))
                {
                    email = employeeInfo[4];
                }
                else
                {
                    age = int.Parse(employeeInfo[4]);
                }
            }

            if (employeeInfo.Length > 5)
            {
                age = int.Parse(employeeInfo[5]);
            }

            Employee employee = new Employee
            (
                name,
                salary,
                position,
                department,
                 email ,
                age
            );

            if (!employeesByDepartment.ContainsKey(department))
            {
                employeesByDepartment[department] = new List<Employee>();
            }

            employeesByDepartment[department].Add(employee);
        }

        string highestAverageSalaryDepartment = employeesByDepartment
            .OrderByDescending(d => d.Value.Average(e => e.Salary))
            .First()
            .Key;

        Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");

        foreach (var employee in employeesByDepartment[highestAverageSalaryDepartment]
            .OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
        };
        break;
    case 3:
        int n3 = int.Parse(Console.ReadLine());
        Dictionary<string, Car> cars = new Dictionary<string, Car>();

        for (int i = 0; i < n3; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            double fuelAmount = double.Parse(carInfo[1]);
            double fuelConsumptionPerKm = double.Parse(carInfo[2], CultureInfo.InvariantCulture);

            Car car = new Car
            {
                Model = model,
                FuelAmount = fuelAmount,
                FuelConsumptionPerKm = fuelConsumptionPerKm,
                DistanceTraveled = 0
            };

            cars[model] = car;
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] commandArgs = command.Split();
            string model = commandArgs[1];
            double amountOfKm = double.Parse(commandArgs[2], CultureInfo.InvariantCulture);

            if (cars.ContainsKey(model))
                cars[model].Drive(amountOfKm);
        }

        foreach (var car in cars.Values)
        {
            Console.WriteLine(car);
        }
        break;
    case 4:
        int n4 = int.Parse(Console.ReadLine());
        List<Car8> cars8 = new List<Car8>();

        for (int i = 0; i < n4; i++)
        {
            string[] carInfo = Console.ReadLine().Split();
            string model = carInfo[0];
            int engineSpeed = int.Parse(carInfo[1]);
            int enginePower = int.Parse(carInfo[2]);
            int cargoWeight = int.Parse(carInfo[3]);
            string cargoType = carInfo[4];

            List<Tire> tires = new List<Tire>();
            for (int j = 5; j < carInfo.Length; j += 2)
            {
                double tirePressure = double.Parse(carInfo[j], CultureInfo.InvariantCulture);
                int tireAge = int.Parse(carInfo[j + 1]);
                Tire tire = new Tire { TirePressure = tirePressure, TireAge = tireAge };
                tires.Add(tire);
            }

            Car8 car = new Car8(model, engineSpeed, enginePower, cargoWeight, cargoType, tires);
            cars8.Add(car);
        }

        string command4 = Console.ReadLine();

        if (command4 == "fragile")
        {
            foreach (var car in cars8)
            {
                if (car.Cargo.CargoType.Equals("fragile")  && car.Tires.Any(t => t.TirePressure < 1))
                { Console.WriteLine(car); }
                   
            }
        }
        else if (command4 == "flamable")
        {
            foreach (var car in cars8)
            {
                if (car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                    Console.WriteLine(car);
            }
        }
        break;
    case 5:
        string[] rectNumInfo = Console.ReadLine().Split();
         int n5 = int.Parse(rectNumInfo[0]); 
        Rectangle[] rectangles = new Rectangle[n5];

       
        for (int i = 0; i < n5; i++)
        {
            string[] rectInfo = Console.ReadLine().Split();
            rectangles[i] = new Rectangle
            {
                Id = rectInfo[0],
                Width = double.Parse(rectInfo[1]),
                Height = double.Parse(rectInfo[2]),
                X = double.Parse(rectInfo[3]),
                Y = double.Parse(rectInfo[4])
            };
        }

        int m = int.Parse(rectNumInfo[1]); 

        
        for (int i = 0; i < m; i++)
        {
            string[] pair = Console.ReadLine().Split();
            Rectangle rect1 = Array.Find(rectangles, r => r.Id == pair[0]);
            Rectangle rect2 = Array.Find(rectangles, r => r.Id == pair[1]);
            bool intersect = rect1.IntersectsWith(rect2);
            Console.WriteLine(intersect ? "true" : "false");
        }
            break;
}
