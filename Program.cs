namespace Topic_7._2___Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Assignment1();

            Assignment2();

            Assignment3();
        }

        public static void Assignment1()
        {
            Console.WriteLine("ASSIGNMENT #1");
            Console.WriteLine();
            Console.WriteLine("Initiating countdown...");
            Console.WriteLine();
            for (int i = 10; i >= 0; i -= 1)
            {
                Console.WriteLine(i + "...");
                Console.WriteLine();
            }
            Console.WriteLine("BLASTOFF.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Assignment2()
        {
            Console.WriteLine("ASSIGNMENT #2");
            Console.WriteLine();
            Console.WriteLine("X \t" + "Y");
            for (int i = -10; i <= 10; i += 1)
            {
                Console.WriteLine(i + "\t" + Math.Pow(i, 2));
            }



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Assignment3()
        {
            int secretName = 10;

            Console.WriteLine("ASSIGNMENT #3");
            Console.WriteLine();
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine();
            if (name.ToLower() == "aldworth")
            {
                secretName = 5;
            }
            for (int i = 1; i <= secretName; i = i + 1)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();




        }




    }
}
