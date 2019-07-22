using System;

namespace cons
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = "msg!";
            var class1 = new ClassLib.Class1();
            Console.WriteLine(class1.Echo(msg));
        }
    }
}
