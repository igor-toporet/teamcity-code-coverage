using CSharpFunctionalExtensions;

namespace TC.CodeCov.Spike
{
    public class Calculator
    {
        public int Add(int x, int y) => x + y;

        //
        // one-liner formatting
        //
        public int Subtract(int x, int y) => x - y;

        //
        // multi-line formatting
        //
        public int Multiply(
            int x, int y
        ) =>
            x * y;

        public Result<int> Divide(int x, int y)
        {
            if (y == 0)
            {
                return Result.Failure<int>("Cannot divide by zero.");
            }

            return x / y;
            // return Result.Success( x / y);
        }

        public Result<int> DivideOneLiner(int x, int y) =>
            y == 0
                ? Result.Failure<int>("Cannot divide by zero.")
                : Result.Success(x / y);

        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
