using MissingNumberTest.Message;
using System.Text.RegularExpressions;

namespace MissingNumberTest.Reader
{
    public partial class InputReader(IMessager messager) : IInputReader
    {
        private readonly IMessager _messager = messager;

        public int[] ReadInput()
        {
            int[] nums = [];

            _messager.StartInput();
            var input = Console.ReadLine();

            var isVerified = VerifyInput(input);

            if (isVerified && input != null)
            {
                return ConvertInput(input);
            }
            else
            {
                return nums;
            }
        }

        private static bool VerifyInput(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            Regex rg = new(Constants.RegexPattern);
            if (rg.IsMatch(input))
            {
                return true;
            }

            return false;
        }

        public static int[] ConvertInput(string input)
        {
            var result = input.Trim('[', ']').Split(", ").Select(int.Parse).ToArray();

            return result;
        }
    }
}
