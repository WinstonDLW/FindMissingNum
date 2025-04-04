namespace MissingNumberTest.Message
{
    public class Messager : IMessager
    {
        public void StartInput()
        {
            Console.WriteLine("Please input a array of integer number. e.g. [3, 0, 1]");
        }

        public void InvalidInput()
        {
            Console.WriteLine("Invalid input. Press 'Y' to input again or other key to exist.");
        }

        public void EndFindingNum(int num)
        {
            Console.WriteLine(num.ToString());
        }

        public void NoMissingNum()
        {
            Console.WriteLine("Didn't find any missing number.");
        }
    }
}
