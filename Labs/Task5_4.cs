namespace Labs
{
    internal class Task5_4
    {
        public static void Run()
        {
            Console.WriteLine("Введите размер массива");
            int size = int.Parse(Console.ReadLine()!);
            string[] startArray = new string[size];
            double[] finalArray = new double[startArray.Length];
            for (int i = 0; i < startArray.Length; i++)
            {
                startArray[i] = Console.ReadLine()!;
                if (int.TryParse(startArray[i], out int @int))
                {
                    if (@int > 0)
                    {
                        finalArray[i] = Factorial(@int);
                    }
                    else
                    {
                        finalArray[i] = @int;
                    }
                }
                else
                {
                    double @double = Math.Round(double.Parse(startArray[i]), 2);
                    @double %= 1;
                    @double *= 100;
                    finalArray[i] = @double;
                }
            }
            Console.WriteLine("Начальный массив");
            foreach (var e in startArray)
                Console.WriteLine(e);
            Console.WriteLine("Финальный массив");
            foreach (var e in finalArray)
                Console.WriteLine(e);
        }
        public static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;
            return factorial;
        }
    }
}
