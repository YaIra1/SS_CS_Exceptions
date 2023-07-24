namespace MathCalculations
{
    public class QuadraticEquationSolver
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public QuadraticEquationSolver(double a, double b, double c)
        {
            if (a == 0 && b == 0)
            {
                throw new NoRootsException("A and B equals zero");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        public double[] Solve()
        {
            if (_a == 0)
            {
                return new double[] { -_c / _b };
            }

            double d = GetDiscriminant();

            if (d < 0)
            {
                throw new NoRootsException("The discriminant is less than zero");
            }

            if (d == 0)
            {
                return new double[] { -_b / (2 * _a) };
            }

            double dRoot = Math.Sqrt(d);

            return new double[] { (-_b + dRoot) / (2 * _a), (-_b - dRoot) / (2 * _a) };

        }

        public double GetDiscriminant()
        {
            return _b * _b - 4 * _a * _c;
        }
    }
}