
using Lab4;
using Lab4.Problem5;
using Lab4.problem6;

int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:

        string[] dimensions = Console.ReadLine().Split();
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        Galaxy stars = new Galaxy(rows, cols);

        
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Let the Force be with you")
                break;

            string[] ivoCoordinates = command.Split();
            int ivoStartRow = int.Parse(ivoCoordinates[0]);
            int ivoStartCol = int.Parse(ivoCoordinates[1]);

            string[] evilCoordinates = Console.ReadLine().Split();
            int evilStartRow = int.Parse(evilCoordinates[0]);
            int evilStartCol = int.Parse(evilCoordinates[1]);

            int collectedStars = stars.CollectStars(ivoStartRow, ivoStartCol, evilStartRow, evilStartCol);
            Console.WriteLine(collectedStars);
        }

            break;
        case 2:

        Hospital hospital = new Hospital();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Output")
                break;

            string[] patientInfo = input.Split();
            string department = patientInfo[0];
            string doctor = patientInfo[1];
            string patientName = patientInfo[2];
            string patientSurname = patientInfo[3];

            string patientFullName = $"{patientName} {patientSurname}";
            

            hospital.AddPatient(department, doctor, patientFullName);
        }

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
                break;

            if (command.Contains(" "))
            {
                string[] commandParts = command.Split();
                string department = commandParts[0];
                int room2 = int.Parse(commandParts[1]);

                var patients = hospital.Departments[department].Rooms[room2]
                    .OrderBy(p => p.Name);

                foreach (var patient in patients)
                    Console.WriteLine(patient.Name);
            }
            else if (hospital.Departments.ContainsKey(command))
            {
                var patients = hospital.Departments[command]
                    .Rooms.Values
                    .SelectMany(p => p)
                    .OrderBy(p => p.Name);

                foreach (var patient in patients)
                    Console.WriteLine(patient.Name);
            }
            else
            {
                var patients = hospital.PatientToDoctor
                    .Where(p => p.Value == command)
                    .Select(p => p.Key)
                    .OrderBy(p => p);

                foreach (var patient in patients)
                    Console.WriteLine(patient);
            }
        }
        break;
    case 3:
        int capacity = int.Parse(Console.ReadLine());
        TreasureBag bagOfWealth = new TreasureBag(capacity);

        string[] safeContent = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < safeContent.Length; i += 2)
        {
            string item = safeContent[i];
            long quantity = long.Parse(safeContent[i + 1]);
            bagOfWealth.AddItem(item, quantity);
        }

        bagOfWealth.PrintResult();
        break;
    
}

