using MissingNumberTest.Factory;

var inputReader = ModelFactory.CreateInputReader();
var numFinder = ModelFactory.CreateNumFinder();
var messager = ModelFactory.CreateMessager();

while (true)
{
    var nums = inputReader.ReadInput();
    if(nums.Length > 1)
    {
        numFinder.FindNum(nums);
    }
    else
    {
        messager.InvalidInput();
        var input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && input.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
        {
            continue;
        }
        else
        {
            break;
        }
    }
}