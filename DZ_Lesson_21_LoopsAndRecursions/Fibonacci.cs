namespace DZ_Lesson_21_LoopsAndRecursions
{
    public class Fibonacci
    {
        public static void Recursive(long f1, long f2, int i, long n)
        { 
            if (i + 2 < n)
            {
                long result = f1 + f2;

                Console.WriteLine($"F({i + 3}) = F({i + 2}) + F({i + 1}) = {f1} + {f2} = {result}");
             
                Recursive(f2, result, i + 1, n);
            }
        }

        public static void Loop(long f1, long f2, int i, long n)
        {
            do
            {
                long result = f1 + f2;
                Console.WriteLine($"F({i + 3}) = F({i + 2}) + F({i + 1}) = {f1} + {f2} = {result}");
                f2 = f1;
                f1 = result;
                i++;
            } while (i + 2 < n);
        }
    }
}
