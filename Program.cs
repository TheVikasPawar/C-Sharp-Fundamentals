using System;

namespace Program
{
    class First
    {
        static void Main(string[] args)
        {
            /*
            Data Type
            byte  -127 to 128  1byte
            short 2 byte
            int 2 byte
            long 4 byte

            flaot   4 byte 7 -8 digit precision
            decimal 4 byte 15- 16 digits
            double  8 byte 28-29

            char     2 byte
            string   varies
            
            Datetime 

            var
            */
            //  byte Byte = 10;
            // short Short = 500;
            // int Int = 29857894;
            // long Long = 78665894654685;
            // float Float = 25.56324656f;
            // double Double = 651554.65746574848d;
            // decimal Decimal = 64546565.6454645487456654m;
            // char Char = 'C';
            // string name = "Vikas";
            // DateTime currentTime = DateTime.Now;
            // var vikas = "Vikas";
            // bool IsActive = false;
            // Console.WriteLine("Byte >>>" + Byte);
            // Console.WriteLine("Short >>>" + Short);
            // Console.WriteLine("Int >>>" + Int);
            // Console.WriteLine("Long >>>" + Long);
            // Console.WriteLine("Float >>>" + Float);
            // Console.WriteLine("Double >>>" + Double);
            // Console.WriteLine("Decimal >>>" + Decimal);
            // Console.WriteLine("Char >>>" + Char);
            // Console.WriteLine("name >>>" + name);
            // Console.WriteLine("currentTime >>>" + currentTime);
            // Console.WriteLine("var >>>" + vikas);
            // Console.WriteLine("isActive >>>" + IsActive);
            // Console.WriteLine("Hello Vikas👋");

            //Video 3
            //Operators
            //Special Symbols to perform specific operation on variables.

            //Arithmetic Operators
            /*
            + - * / % 
            */
            int num1 = 10, num2 = 20;

            Console.WriteLine("---------Arithmetic Operator---------");
            Console.WriteLine("Addition is       " + (num1 + num2));
            Console.WriteLine("Subtraction is    " + (num1 - num2));
            Console.WriteLine("Multiplication is " + (num1 * num2));
            Console.WriteLine("Division is       " + (num1 / num2));
            Console.WriteLine("Reminder is       " + (num1 % num2));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("---------Relation (Comparison) Operator---------");
            Console.WriteLine("==" + (num1 == num2));
            Console.WriteLine("!=" + (num1 != num2));
            Console.WriteLine("<" + (num1 < num2));
            Console.WriteLine(">" + (num1 > num2));
            Console.WriteLine("<=" + (num1 <= num2));
            Console.WriteLine(">=" + (num1 >= num2));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("---------Logical Operators------------");
            Console.WriteLine("&&" + (true && false));
            Console.WriteLine("||" + (true || false));
            Console.WriteLine("!" + (!true));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("----------Assignment Operator----------");
            Console.WriteLine("num1=+5" + (num1 += num2));
            Console.WriteLine("num1=-5" + (num1 -= num2));
            Console.WriteLine("num1*-5" + (num1 *= num2));
            Console.WriteLine("num1=5" + (num1 = 10));
            Console.WriteLine("num1*=5" + (num1 *= 10));
            Console.WriteLine("num1/=5" + (num1 /= 10));
            Console.WriteLine("num1%=5" + (num1 %= 10));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("----------Unary Opearor----------------");
            Console.WriteLine("num1++" + (num1++));
            Console.WriteLine("num1--" + (num1--));
            Console.WriteLine("+num1" + num1);
            Console.WriteLine("num1" + -num1);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------Ternary Operator-------------");
            Console.WriteLine("condition ? true : false", (num1 > num2 ? true : false));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------Null-Coalescaping Operator-------------");
            Console.WriteLine("??");
        }
    }
}