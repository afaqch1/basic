using System;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, n;
            int n1;
            System.Console.WriteLine("/////////////////////////////input/output////////////////////////");
            //input/output
            System.Console.WriteLine("Enter any string:");
            s = System.Console.ReadLine();
            System.Console.WriteLine(s);

            //if else
            System.Console.WriteLine("//////////////////////////if-else check//////////////////////");
            System.Console.WriteLine("Write any number:");
            n = System.Console.ReadLine();
            n1 = Convert.ToInt32(n);
            if (n1 % 2 == 0)
            {
                System.Console.WriteLine("The num is divisble by 2.");
            }
            else
            {
                System.Console.WriteLine("The num is not divisble by 2.");
            }

            //for loop
            System.Console.WriteLine("/////////////////////////////for loop////////////////////////");

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(i);
            }

            //while loop
            System.Console.WriteLine("/////////////////////////////while loop////////////////////////");
            int j = 0;
            while (j < 5)
            {
                System.Console.WriteLine(j);
                j++;
            }

            //do-while
            System.Console.WriteLine("/////////////////////////////do while////////////////////////");
            int m = 1;
            do
            {
                System.Console.WriteLine("I am in do while loop");

            }
            while (m < 1);

            //foreach loop
            System.Console.WriteLine("/////////////////////////////foreach loop////////////////////////");
            int male = 0;
            int female = 0;
            char[] array = { 'm', 'f', 'f', 'm', 'f', 'f', 'f', 'm' };
            foreach(var c in array)
            {
                if (c == 'm')
                    male++;
                else if (c == 'f')
                    female++;
            }
            System.Console.WriteLine("males are ={0}", male);
            System.Console.WriteLine("females are={0}", female);

        }
    }
}