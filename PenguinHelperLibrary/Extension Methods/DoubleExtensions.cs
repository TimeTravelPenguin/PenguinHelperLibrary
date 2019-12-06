using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    public static class DoubleExtensions
    {
        public static bool IsZero(this double value)
        {
            return value.IsEqualTo(0.0);
        }

        public static bool IsEqualTo(this double lhs, double rhs)
        {
            return Math.Abs(lhs - rhs) < double.Epsilon;
        }

        public static bool IsGreaterThanZero(this double lhs)
        {
            return lhs >= double.Epsilon;
        }

        public static bool AbsIsGreaterThanZero(this double lhs)
        {
            return Math.Abs(lhs).IsGreaterThanZero();
        }

        public static bool IsGreaterThan(this double lhs, double rhs)
        {
            return (lhs - rhs).IsGreaterThanZero();
        }

        public static bool IsGreaterThanOrEqual(this double lhs, double rhs)
        {
            return lhs.IsGreaterThan(rhs) || lhs.Equals(rhs);
        }
    }
}