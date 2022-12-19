namespace Labs
{
    internal static class Task5_1
    {
        public static void Run()
        {
            float last = float.NaN;
            while (true)
            {
                string input = Console.ReadLine()!;
                if (input == "q")
                {
                    break;
                }
                if (int.TryParse(input, out int @int))
                {
                    Console.WriteLine((char)@int);
                    continue;
                }
                if (float.TryParse(input, out float @float))
                {
                    if (@float == last)
                    {
                        break;
                    }
                    last = @float;
                }
            }
        }
    }
}
