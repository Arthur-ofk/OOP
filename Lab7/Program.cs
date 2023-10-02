using Lab7.problem1;
using Lab7.problem12;
using Lab7.problem2;
using Lab7.problem4;
using Lab7.problem5;
using Lab7.problem5.Contracts;

int opt = int.Parse(Console.ReadLine());
switch (opt)
{
	case 1:
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthiable birthable = new Citizen(name, age, id, birthdate);
        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthdate);
        break;
        case 2:
        string driverName = Console.ReadLine();
        Ferrari ferrari = new Ferrari(driverName);
        Console.WriteLine(ferrari);
        break;
    case 3:
        string[] phoneNumbers = Console.ReadLine().Split();
        string[] sitesToVisit = Console.ReadLine().Split();
        Smartphone smartphone = new Smartphone();

        foreach (var number in phoneNumbers)
        {
            if (number.Any(c => !char.IsDigit(c)))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                smartphone.Call(number);
            }
        }

        foreach (var site in sitesToVisit)
        {
            smartphone.Browse(site);
        }
        break;
    case 4:
        string[] phoneNumbers4 = Console.ReadLine().Split();
        string[] sitesToVisit4 = Console.ReadLine().Split();

        Smartphone smartphone4 = new Smartphone();

        foreach (var number in phoneNumbers4)
        {
            if (number.Any(c => !char.IsDigit(c)))
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                smartphone4.Call(number);
            }
        }

        foreach (var site in sitesToVisit4)
        {
            smartphone4.Browse(site);
        }
        break;
    case 5:
        var people = new Dictionary<string, IBuyer>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string name5 = tokens[0];
            int age5 = int.Parse(tokens[1]);

            if (tokens.Length == 4)
            {
                var citizen = new Citizen5
                {
                    Name = name5,
                    Age = age5,
                    Id = tokens[2],
                    Birthdate = DateTime.ParseExact(tokens[3], "dd/MM/yyyy", null)
                };
                people[name5] = citizen;
            }
            else if (tokens.Length == 3)
            {
                var rebel = new Rebel
                {
                    Name = name5,
                    Age = age5,
                    Group = tokens[2]
                };
                people[name5] = rebel;
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            if (people.ContainsKey(input))
            {
                people[input].BuyFood();
            }
        }

        int totalFood = people.Values.Sum(p => p.Food);
        Console.WriteLine(totalFood);
        break;
       default:
		break;
}

