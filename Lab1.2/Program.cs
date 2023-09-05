Console.WriteLine("choose problem(14,15,16,17)");
int option = int.Parse(Console.ReadLine());
switch(option)
{
    //Biggest of three
    case 14:
        int a = int.Parse(Console.ReadLine());  
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        //Console.WriteLine(Math.Max(Math.Max(a,b),c));
        if ((a > b) && (a > c))
        { Console.WriteLine(a); }
        else if ((b > c) && (b > a))
        { Console.WriteLine(b); }
        else if ((c> b) && (c > a))
        { Console.WriteLine(c); }
        
        break;

    //Sign of product
    case 15:
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        string product;
        if((d<0)&&((e<0) ^ (f<0))||((e<0)&&(f<0)))
        { product = "positive"; }
        else
        { product = "negative"; }
        break;

    //Number as a Day of Week
    case 16:
        string day = Console.ReadLine();
        if (day.Equals('1')) { Console.WriteLine("Monday"); }
        else if (day.Equals('2')) { Console.WriteLine("Tuesday"); }
        else if (day.Equals('3')) { Console.WriteLine("Wedneday"); }
        else if (day.Equals('4')) { Console.WriteLine("Thursday"); }
        else if (day.Equals('5')) { Console.WriteLine("Friday"); }
        else if (day.Equals('6')) { Console.WriteLine("Saturday"); }
        else if (day.Equals('7')) { Console.WriteLine("Sunday"); }
        else { Console.WriteLine("not valid"); }
            
        break;

    //Calculate N!
    case 17:
        int argument = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = argument; i > 0; i--)
            result *= i;
        Console.WriteLine(result);
        break;
}