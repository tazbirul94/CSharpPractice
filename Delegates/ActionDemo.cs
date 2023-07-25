namespace Delegates;

public class ActionDemo
{
    private Action<int, string> testAction;
    void TestActionExample(int input, string str)
    {
        for(int i=0; i< input; i++)
        {
            Console.WriteLine(str);
        }
    }

    void TestActionExample2(int input, string str)
    {
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine(str);
        }
    }

    public void PrintAction()
    {
        testAction = TestActionExample;
        testAction += TestActionExample2;

        testAction(10, "Hi");

        actionTest(TestActionExample2);

    }

    void actionTest(Action<int> config)
    {
        Console.WriteLine(config.ToString());
    }

    void TestActionExample2(int input)
    {
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("1");
        }
    }



}
