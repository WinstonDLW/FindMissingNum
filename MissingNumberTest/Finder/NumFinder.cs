using MissingNumberTest.Message;

namespace MissingNumberTest.Finder
{
    public class NumFinder(IMessager messager) : INumFinder
    {
        private readonly IMessager _messager = messager;

        public void FindNum(int[] nums)
        {
            int missingValue = 0;

            var numsSorted = nums.Order().ToList();

            foreach(int num in numsSorted)
            {
                if(num == missingValue)
                {
                    missingValue++;
                }
                else
                {
                    _messager.EndFindingNum(missingValue);
                    break;
                }
            }

            if(missingValue == numsSorted.Last() + 1)
            {
                _messager.NoMissingNum();
            }
        }
    }
}
