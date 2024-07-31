using System.Text;

namespace Square_Every_Digit
{
    internal class Program
    {
        public static int SquareDigits(int n)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in n.ToString())
            {
                result.Append((int)char.GetNumericValue(c) * (int)char.GetNumericValue(c));
            }

            return Convert.ToInt32(result.ToString());
        }


        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(9119));
        }
    }
}