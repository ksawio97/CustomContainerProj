using System;

namespace CustomContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> l = new MyList<int>();

            l.Append(1);
            l.Append(2);
            l.Append(3);

            l[3] = 4;
            foreach (var element in l)
            {
                Console.WriteLine(element);
            }
        }
    }
}
