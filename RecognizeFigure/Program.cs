using System;

namespace RecognizeFigure
{
    public class Program
    {
        static Boolean isSquare(int a, int b, int c, int d)
        {
        
            if (a == b && b == c && c == d)
                return true;
            else
                return false;
        }
        static Boolean isRectangle(int a, int b, int c, int d)
        {
            if (a == b && a == c && a == d && b == c && b == d)
                return true;
            else if (a == b && c == d)
                return true;
            else if (a == d && c == b)
                return true;
            else if (a == c && d == b)
                return true;
            else
                return false;
        }
        static Boolean isTriangle(int a, int b, int c)
        {
            if (a!=b && b!=c)
                return true;             
            else
                return false;
        }
        static Boolean isEquilateralTriangle(int a, int b, int c)
        {
            if (a == b && b == c)
                return true;
            else
                return false;
        }

        static Boolean isIsosceleTriangle(int a, int b, int c)
        {
            if (a == b || a == c || b == c)
                return true;
            else
                return false;
        }

        static void Main()
        {
           Console.WriteLine("Podaj długości 4 boków w celu rozpoznania figury");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var d = Convert.ToInt32(Console.ReadLine());
         
            if (isSquare(a,b,c,d)) 
                Console.Write(" Rozpoznano Kwadrat");  
            else if (isRectangle(a,b,c,d))
                Console.WriteLine(" Rozpoznano Prostokąt");
            else if (isTriangle(a,b,c))
                Console.Write("Rozpoznano Trójkąt Różnoboczny");
            else if (isEquilateralTriangle(a,b,c))
                Console.Write("Rozpoznano Trójkąt Równoboczny");
            else if (isIsosceleTriangle(a,b,c))
                Console.Write("Rozpoznano Trójkąt Równoramienny");
            else 
                Console.WriteLine("Nierozpoznano");          

        }
    }
}
