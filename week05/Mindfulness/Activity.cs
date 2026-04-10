public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Are you ready?");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("Good job!!!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Count;
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}