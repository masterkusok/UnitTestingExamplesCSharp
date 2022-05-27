using System;

namespace Calculator
{
    public static class MyCalc
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Substract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException("Y argument should not be equal to zero");
            return x / y;
        }
    }
}
