namespace MissingNumberTest.Message
{
    public interface IMessager
    {
        void StartInput();

        void InvalidInput();

        void EndFindingNum(int num);

        void NoMissingNum();
    }
}
