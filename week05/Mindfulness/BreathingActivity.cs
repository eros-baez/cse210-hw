public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity helps you relax by breathing slowly.")
    { }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        End();
    }
}