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
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(3);

        int time = 0;

        while (time < _duration)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(4);
            time += 4;
        }

        End();
    }
}