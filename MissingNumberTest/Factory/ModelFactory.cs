using MissingNumberTest.Finder;
using MissingNumberTest.Message;
using MissingNumberTest.Reader;

namespace MissingNumberTest.Factory
{
    public class ModelFactory
    {
        public static IInputReader CreateInputReader()
        {
            return new InputReader(CreateMessager());
        }

        public static IMessager CreateMessager()
        {
            return new Messager();
        }

        public static INumFinder CreateNumFinder()
        {
            return new NumFinder(CreateMessager());
        }
    }
}
