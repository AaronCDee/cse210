using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        CyclingActivity cycling = new CyclingActivity(new DateOnly(2023, 10, 24), 50, 25);
        activities.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity(new DateOnly(2023, 10, 23), 60, 15);
        activities.Add(swimming);

        RunningActivity running = new RunningActivity(new DateOnly(2023, 10, 22), 30, 5);
        activities.Add(running);

        Console.WriteLine("Activities:");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}