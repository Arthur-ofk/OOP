
using Lab2;

Console.WriteLine("select option");
int option =int.Parse(Console.ReadLine());
switch(option)
{
    case 1:
        string[] a=Console.ReadLine().Split(' ');
        string[] b=Console.ReadLine().Split(' ');
        Task1 task1 = new Task1();
       int length= task1.Scan(a, b);
        if (length > 0) { Console.WriteLine(length); }
        else { Console.WriteLine("There is no common end."); }
        break;
    case 2:
        int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        int n = int.Parse(Console.ReadLine());
      
        Task2 task2 = new Task2();
        foreach (var item in task2.SumArray(array,n))
        {
            Console.WriteLine(item);
        }
        break;
    case 3:
        int[] array3 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        Task3 task3 = new Task3();
        if(!(array3.Length % 4 == 0)){
            Console.WriteLine("wrong quantity of numbers");
            break;
        }
        else
        {
            foreach (var item in task3.Fold(array3))
            {
                Console.WriteLine(item);
            }
        }
        
        break;
    case 4:
        int n4 = int.Parse(Console.ReadLine());
        Task4 task4 = new Task4();
        bool[] primes= task4.IsPrime(n4);
        for (int i = 2; i <= n4; i++)
        {
            if (primes[i])
            {
                Console.Write(i + " ");
            }
        }
        break;
    case 5:
        char[] array1 = Console.ReadLine().ToCharArray();
        char[] array2 = Console.ReadLine().ToCharArray();
        Task5 task5 = new Task5();
        foreach (var item in task5.Compare(array1,array2))
        {
            Console.WriteLine(item);
        }
        
        break;
    case 6:
        int[] array6 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        Task6 task6 = new Task6();
        var result6 = task6.Find(array6);
        
        foreach (var item in result6)
        {
            Console.Write(item);
            Console.Write(' ') ;
        }
        break;
    case 7:
        int[] array7 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        Task7 task7 = new Task7();
        var result7 = task7.FindLIS(array7);
        foreach (var item in result7)
        {
            Console.Write(item);
        }
        break;
    case 8:
        int[] array8 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        Task8 task8 = new Task8();
        Tuple<int, int> result8 = task8.Find(array8);
        Console.WriteLine("most frequent number is "+ result8.Item1 +", occured "+ result8.Item2+" times");
        break;
    case 9:
        string word = Console.ReadLine();
        Task9 task9 = new Task9();
        foreach (var item in task9.Index(word))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        break;
    case 10:
        int[] array10 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        int n10 = int.Parse(Console.ReadLine());
        Task10 task10 = new Task10();
        foreach (var pair in task10.Pairs(array10,n10))
        {
            Console.WriteLine($"({pair[0]}, {pair[1]})");
        }
        break;

}    

