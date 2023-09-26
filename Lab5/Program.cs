
using Lab5;
using Lab5.Problem5;

int option = int.Parse(Console.ReadLine());
switch (option)
{
	case 1:
        Box1 myBox = new Box1(5, 4, 3);

        
        Console.WriteLine("Surface Area: " + myBox.CalculateSurfaceArea());
        Console.WriteLine("Lateral Surface Area: " + myBox.CalculateLateralSurfaceArea());
        Console.WriteLine("Volume: " + myBox.CalculateVolume());
        break;
        case 2:
        try
        {
           
            string chickenName = "Mara";
            int chickenAge = 10;

           
            Chicken chicken = new Chicken(chickenName, chickenAge);

           
            Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        break;
    case 3:
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string[] peopleInput = Console.ReadLine().Split(';');
        foreach (var personData in peopleInput)
        {
            string[] personInfo = personData.Split('=');
            string name = personInfo[0];
            double money = double.Parse(personInfo[1]);
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("Name cannot be empty.");
                if (money < 0)
                    throw new ArgumentException("Money cannot be negative.");
                people[name] = new Person(name, money);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }
        }

        string[] productsInput = Console.ReadLine().Split(';');
        foreach (var productData in productsInput)
        {
            string[] productInfo = productData.Split('=');
            string name = productInfo[0];
            double cost = double.Parse(productInfo[1]);
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("Product name cannot be empty.");
                products[name] = new Product(name, cost);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }
        }

        string purchase;
        while ((purchase = Console.ReadLine()) != "END")
        {
            string[] purchaseInfo = purchase.Split();
            string personName = purchaseInfo[0];
            string productName = purchaseInfo[1];

            if (people.ContainsKey(personName) && products.ContainsKey(productName))
            {
                Person person = people[personName];
                Product product = products[productName];

                if (person.Money >= product.Cost)
                {
                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {productName}");
                }
            }
        }

        foreach (var person in people.Values)
        {
            Console.WriteLine(person);
        }
        break;
    case 4:
        try
        {
            string pizzaName = Console.ReadLine().Split()[1];

            string[] doughInput = Console.ReadLine().Split();
            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double doughWeight = double.Parse(doughInput[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);

            Pizza pizza = new Pizza(pizzaName, dough);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] toppingInput = input.Split();
                string toppingType = toppingInput[1];
                double toppingWeight = double.Parse(toppingInput[2]);

                try
                {
                    Topping topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return;
                }
            }

            Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories:F2} Calories.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        break;

    default:
		break;
}
