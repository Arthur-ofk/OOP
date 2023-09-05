
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
       // Array.Reverse(array);
        Task2 task2 = new Task2();
        foreach (var item in task2.RotateArray( array, n))
        {
            Console.Write(item);
        }
        
        break;

}    

