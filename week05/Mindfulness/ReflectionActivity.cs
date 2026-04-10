using System.Linq;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "Reflect on meaningful experiences.")
    { }

    public void Run()
    {
        Start();

        Random rand = new Random();
        _prompts = _prompts.OrderBy(x => rand.Next()).ToList();
        _questions = _questions.OrderBy(x => rand.Next()).ToList();
        Console.WriteLine(_prompts[0]);
        Console.WriteLine("Reflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int index = 0;

        while (DateTime.Now < endTime && index < _questions.Count)
        {
            Console.WriteLine(_questions[index]);
            ShowSpinner(4);
            index++;
        }

        End();
    }
}