using Lab9;
using Lab9.Problem6;
using Lab9.Problem7;


int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 2:
        ListyIterator<string>? listyIterator = null;

        while (true)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];

            if (action == "END")
            {
                break;
            }

            try
            {
                switch (action)
                {
                    case "Create":
                        List<string> elements = command.Skip(1).ToList();
                        listyIterator = new ListyIterator<string>(elements);
                        break;

                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;

                    case "Print":
                        listyIterator.Print();
                        break;

                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
        break;
    case 3:
        CustomStack<int> customStack = new CustomStack<int>();

        while (true)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "END")
            {
                break;
            }

            switch (command[0])
            {
                case "Push":
                    int[] elements = command.Skip(1)
                        .Select(int.Parse)
                        .ToArray();
                    customStack.Push(elements);
                    break;

                case "Pop":
                    try
                    {
                        customStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }

        foreach (var item in customStack)
        {
            Console.WriteLine(item);
        }

        foreach (var item in customStack)
        {
            Console.WriteLine(item);
        }
        break;
    case 4:
        int[] stoneNumbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        Lake lake = new Lake(stoneNumbers);

        Console.WriteLine(string.Join(", ", lake));
        break;
    case 5:
        List<Person> people = new List<Person>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
                break;

            string[] personInfo = input.Split();
            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);
            string town = personInfo[2];

            Person person = new Person
            {
                Name = name,
                Age = age,
                Town = town
            };

            people.Add(person);
        }

        int n = int.Parse(Console.ReadLine());
        n--; 

        if (n >= 0 && n < people.Count)
        {
            Person targetPerson = people[n];
            int equalPeople = 0;
            int notEqualPeople = 0;

            foreach (var person in people)
            {
                int comparison = targetPerson.CompareTo(person);
                if (comparison == 0)
                    equalPeople++;
                else
                    notEqualPeople++;
            }

            int totalPeople = people.Count;

            if (equalPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {totalPeople}");
            }
        }
        break;
    case 6:
        int N = int.Parse(Console.ReadLine());

        SortedSet<Person6> nameSortedSet = new SortedSet<Person6>(new NameComparator());
        SortedSet<Person6> ageSortedSet = new SortedSet<Person6>(new AgeComparator());

        for (int i = 0; i < N; i++)
        {
            string[] personInfo = Console.ReadLine().Split();
            string name = personInfo[0];
            int age = int.Parse(personInfo[1]);

            Person6 person = new Person6 { Name = name, Age = age };

            nameSortedSet.Add(person);
            ageSortedSet.Add(person);
        }

        foreach (var person in nameSortedSet)
        {
            Console.WriteLine(person);
        }

        foreach (var person in ageSortedSet)
        {
            Console.WriteLine(person);
        }
        break;
}

