using System;

namespace Lab2
{ 
    public class Program
    {
        static public int Check1(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Whole minutes " + a.ToString() + "/" + b.ToString() + "=" + c.ToString());
            return c;
        }
        static void Main(string[] args)
        {
            int t = 35;
            Console.WriteLine("Seconds past");
            string S1 = Console.ReadLine();
            int a = int.Parse(S1);
            int b = 60;//
            Check1(a, b);
            Console.CursorVisible = false;
            while (true)
            {
                Console.Write("//");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(t);
                Console.Write("-");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(t);
                Console.Write("\\");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(t);
                Console.Write("|");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                System.Threading.Thread.Sleep(t);
            }
        }
    }
}
