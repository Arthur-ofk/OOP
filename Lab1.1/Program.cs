Console.WriteLine("choose problem(8,9,10,11,12,13)");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    //Average
    case 8:
     int a = int.Parse(Console.ReadLine());
     int b = int.Parse(Console.ReadLine());
     int c = int.Parse(Console.ReadLine());
     double average= (a+b+c)/3;
     Console.WriteLine(average);
        break; 

    //Trapezoid
    case 9:
        int sideA = int.Parse(Console.ReadLine());
        int sideB = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double area = ((sideA + sideB) / 2)*h;
        Console.WriteLine(area);
        break;

    //Last Digit
    case 10:
        int n=int.Parse(Console.ReadLine());
        int lastDigit = n % 10;
        Console.WriteLine(lastDigit);
        break;

    //N-th Digit
    case 11:
        double number =double.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        int nDigit = (((int)(number / (Math.Pow(10, i - 1)) % 10)));
        double f = Math.Floor(Math.Log10(number) + 1);
        if (i>f)
        {
            Console.WriteLine('-');
            break;
        }
        Console.WriteLine( nDigit) ;
        break;

    //Big and Odd
    case 12:
        int k = int.Parse(Console.ReadLine());
        bool result;
        if (k % 2 == 0 && k > 20)
        {
            result = true;
        }
        else
        { 
            result = false; 
        }
        Console.WriteLine(result);

        break;

    //Pure Divisor
    case 13:
        int num =int.Parse(Console.ReadLine());
        bool resul;
        if (num%9==0||num%11==0||num%13==0)
        {
            resul = true;
        }
        else
        {
            resul = false;
        }
        Console.WriteLine(resul);
        break;
    


}