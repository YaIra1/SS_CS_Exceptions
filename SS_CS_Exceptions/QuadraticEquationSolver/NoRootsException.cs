namespace MathCalculations
{
    public class NoRootsException : ApplicationException
    {
        public NoRootsException()
        {
        }

        public NoRootsException(string? message) : base(message)
        {
        }
    }
}
