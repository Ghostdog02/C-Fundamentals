using System.Runtime.CompilerServices;

namespace Program
{
    public class Fraction
    {
        public int Numerator { get; set; }

        public int Denumerator { get; set; }

        public decimal DecimalValue { get => ((decimal)Numerator / (decimal)Denumerator); }

        public Fraction(int numerator, int denumerator)
        {
            if (numerator < 0 && denumerator < 0)
            {
                numerator = -numerator;
                denumerator = -denumerator;
            }

            this.Numerator = numerator;
            this.Denumerator = denumerator;
            if ((Numerator == Denumerator) && (Numerator != 0))
            {
                Denumerator = 1;
                Denumerator = 1;
            }

            if (!IsValidFraction(Numerator, Denumerator))
                throw new ArgumentException();

            int gcd = GetGCD();
            this.Numerator /= gcd;
            this.Denumerator /= gcd;
        }

        public Fraction() { }
        public void Parse(string fraction)
        {
            string[] numbers = fraction.Split('/');
            this.Numerator = int.Parse(numbers[0]);
            this.Denumerator = int.Parse(numbers[1]);
            if (Numerator < 0 && Denumerator < 0)
            {
                Numerator = -Numerator;
                Denumerator = -Denumerator;
            }

            if (Numerator == Denumerator)
            {
                Denumerator = 1;
                Denumerator = 1;
            }

            if (!IsValidFraction(Numerator, Denumerator))
                throw new ArgumentException();

            int gcd = GetGCD();
            this.Numerator /= gcd;
            this.Denumerator /= gcd;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (!(obj is Fraction))
                return false;

            return (this.Numerator == ((Fraction)obj).Numerator) &&
                (this.Denumerator == ((Fraction)obj).Denumerator);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + Numerator.GetHashCode();
            hash = (hash * 7) + Denumerator.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}";
        }

        public int GetGCD()
        {
            int a = Math.Abs(Numerator);
            int b = Math.Abs(Denumerator);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return Math.Max(a, b);
        }

        public bool IsValidFraction(int numerator, int denumerator)
        {
            if ((numerator == 0 && denumerator == 0) || (denumerator == 0))
                return false;
            return true;
        }

        static void Main() { }
    }
}