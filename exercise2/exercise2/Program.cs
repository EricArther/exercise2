using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            //Four();
            Five();

            Console.ReadKey();
        }

        public static void One()
        {
            Random random = new Random();

            Console.Write("give me a number: ");
            int[] numbers = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
            }

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}: {numbers[i]}");
            }
        }

        public static void Two()
        {
            Random random = new Random();

            int[] numbers = new int[100];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 101);
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        public static void Three()
        {
            string[] names = new string[10];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"name {i+1}: ");
                names[i] = Console.ReadLine();
            }

            string[] namesCopy = names;

            Array.Sort(namesCopy);

            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{namesCopy[i]}");
            }
        }

        public static void Four()
        {
            int[] numbers = new int[10];
            int max = 0;
            int min = 0;
            double average = 0;

            for(int i = 0;i< numbers.Length; i++)
            {
                Console.Write($"number {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    max = numbers[i];
                    min = numbers[i];
                }
                else
                {
                    if (numbers[i] > max) max = numbers[i];
                    if (numbers[i] < min) min = numbers[i];
                }

                average += numbers[i];
            }

            average /= numbers.Length;

            Console.WriteLine($"max: {max}");
            Console.WriteLine($"min: {min}");
            Console.WriteLine($"average: {average}");
        }

        public static void Five()
        {
            Console.Write("size: ");
            int[] first = new int[int.Parse(Console.ReadLine())];

            for(int i = 0; i < first.Length; i++)
            {
                Console.Write($"number {i+1}: ");
                first[i] = int.Parse(Console.ReadLine());
            }

            int[] second = (int[])first.Clone();
            Array.Sort(second);

            int[] third = (int[])second.Clone();
            Array.Reverse(third);

            int maxDigit = second[0].ToString().Length;

            Console.WriteLine();
            Console.WriteLine("First Array");
            for(int i = 1; i <= first.Length; i++)
            {
                Console.Write($"{first[i-1], -4} ");
                if (i % 5 == 0 || i == first.Length) Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Second Array");
            for (int i = 1; i <= second.Length; i++)
            {
                Console.Write($"{second[i-1]} ");
                if (i % 5 == 0 || i == second.Length) Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Third Array");
            for (int i = 1; i <= third.Length; i++)
            {
                Console.Write($"{third[i-1]} ");
                if (i % 5 == 0 || i == third.Length) Console.WriteLine();
            }

        }
    }
}
