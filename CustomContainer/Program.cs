using System;

namespace CustomContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> l = new MyList<int>();

            l.Append(2);
            l.Append(3);
            l.Append(5);
            l.Append(6);
            Console.WriteLine(l.Show(0));

            Console.WriteLine(l.Show(1));
        }
    }
}
