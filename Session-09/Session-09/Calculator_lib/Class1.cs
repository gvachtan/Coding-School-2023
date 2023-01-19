namespace Calculator_lib
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double RaiseToPower(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double SquareRoot(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
