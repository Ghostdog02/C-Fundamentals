namespace SetImplementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var f1 = new HashedSet<int>();
            var f2 = new HashedSet<int>();
            var f3 = new HashedSet<int>();

            for (int i = 0; i <= 5; i++)
            {
                //int result1 = CalculateFormulaOne(i);
                //f1.Add(result1);
                Console.WriteLine(CalculateFormulaTwo(i));
                Console.WriteLine();

            }

        }

        static int CalculateFormulaOne(int k)
        {
            if (k >= 0)
            {
                int f = CalculateFormulaOne(k - 1);
                k = 2 * f + 3;
                return k;
            }

            else
            {
                return k;
            }

            //f1(k) = 2 * f1(k - 1) + 3;
        }

        static int CalculateFormulaTwo(int k)
        {
            if (k >= 0 && k <= 100_000)
            {
                int f = CalculateFormulaTwo(k - 1);
                k = 3 * f + 1;
                return k;
            }

            else
            {
                return k;
            }

            //f2(k) = 3*f2(k-1) + 1;
        }

        static int CalculateFormulaThree(int k)
        {
            if (k >= 0)
            {
                int f = CalculateFormulaThree(k - 1);
                k = 2 * f - 1;
                return k;
            }

            else
            {
                return k;
            }

            //f3(k) = 2*f3(k-1) - 1;
        }
    }
}
