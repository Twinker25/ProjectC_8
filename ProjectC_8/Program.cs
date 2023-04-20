namespace ProjectC_8
{
    public delegate double MyDelegate(double a, double b);
    class Program
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            double rez;
            do
            {
                Console.Write("\nNum 1: ");
                double ch1 = int.Parse(Console.ReadLine());
                Console.Write("Num 2: ");
                double ch2 = int.Parse(Console.ReadLine());
                Console.Write("Calculator:\n1 - Add\n2 - Subtract\n3 - Multi\n4 - Divide\nEnter operation: ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        MyDelegate myDelegate1 = Add;
                        rez = myDelegate1(ch1, ch2);
                        Console.WriteLine("Result: {0}", rez);
                        break;
                    case 2:
                        MyDelegate myDelegate2 = Sub;
                        rez = myDelegate2(ch1, ch2);
                        Console.WriteLine("Result: {0}", rez);
                        break;
                    case 3:
                        MyDelegate myDelegate3 = Mult;
                        rez = myDelegate3(ch1, ch2);
                        Console.WriteLine("Result: {0}", rez);
                        break;
                    case 4:
                        MyDelegate myDelegate4 = Div;
                        rez = myDelegate4(ch1, ch2);
                        Console.WriteLine("Result: {0}", rez);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (true);
        }
    }
}