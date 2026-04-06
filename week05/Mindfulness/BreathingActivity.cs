public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity helps you relax by breathing slowly.")
    { }

    public void Run()
    {
        Start();

        int time = 0;

        while (time < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            time += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            time += 3;
        }

        End();
    }
}