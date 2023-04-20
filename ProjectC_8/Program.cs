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
                MyDelegate myDelegate = null;
                Console.Write("\nNum 1: ");
                double ch1 = int.Parse(Console.ReadLine());
                Console.Write("Num 2: ");
                double ch2 = int.Parse(Console.ReadLine());
                Console.Write("Calculator:\n1 - Add\n2 - Subtract\n3 - Multi\n4 - Divide\nEnter operation: ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        myDelegate = Add;
                        break;
                    case 2:
                        myDelegate = Sub;
                        break;
                    case 3:
                        myDelegate = Mult;
                        break;
                    case 4:
                        myDelegate = Div;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
                rez = myDelegate(ch1, ch2);
                Console.WriteLine("Result: {0}", rez);
            } while (true);
        }
    }
}