namespace Utils
{
    using System;

    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = int.Parse(Console.ReadLine());
            int greater = Utils.Greater(x, y);
            Console.WriteLine("Наибольшее введенное число " + greater);

            Console.WriteLine("До перестановки: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После перестановки: " + x + "," + y);

        }
    }
}
