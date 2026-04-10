public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?"
    };

    public ListingActivity() : base(
        "Listing Activity",
        "List as many positive things as you can.")
    { }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        ShowCountdown(3);
        Console.WriteLine("Start listing items:");
        

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        End();
    }
}