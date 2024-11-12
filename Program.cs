namespace Calculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("⋅˚₊‧ ୨୧ ‧₊˚ ⋅ CALCULATOR ⋅˚₊‧ ୨୧ ‧₊˚ ⋅");
            Console.WriteLine("");
            Console.WriteLine("What would you like to calculate today? ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - multiply");
            Console.WriteLine("5 - exit");
            Console.WriteLine("");
            Console.WriteLine("⋆˚࿔ Choose your option 𝜗𝜚˚⋆");
            Console.WriteLine("");

            short choice = short.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (choice)
            {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Div(); break;
                case 4: Mult(); break;
                case 5:
                {
                    Console.WriteLine(". ݁₊ ⊹ . ݁˖ . ݁enough calculating for today. ݁₊ ⊹ . ݁˖ . ݁");
                    System.Environment.Exit(0); break;
                }
                default: Menu(); break;
            }
        }
        
        static void Sum()
        {
            Console.Clear();
            
            Console.WriteLine("First number: ");
            var n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            var n2 = float.Parse(Console.ReadLine());

            Console.WriteLine(""); //skip a line

            float result = n1 + n2;
            Console.WriteLine($"The sum result is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtract()
        {
            Console.Clear();
            
            Console.WriteLine("First number: ");
            var n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            var n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float result = n1 - n2;
            Console.WriteLine($"The subtraction result is: {result}");
            Console.ReadKey();
            Menu();
        }
        
        static void Div()
        {
            Console.Clear();
            
            Console.WriteLine("First number: ");
            var n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            var n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float result = n1 / n2;
            Console.WriteLine($"The division result is: {result}");
            Console.ReadKey();
            Menu();
        }
        
        static void Mult()
        {
            Console.Clear();
            
            Console.WriteLine("First number: ");
            var n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            var n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float result = n1 * n2;
            Console.WriteLine($"The multiplication result is: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
