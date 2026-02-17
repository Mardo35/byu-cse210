using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // One list
        List<Activity> activities = new List<Activity>();

        // Create one of each activity
        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("03 Nov 2022", 45, 12.5));
        activities.Add(new Swimming("03 Nov 2022", 20, 40));

        // Iterate and display
        foreach (Activity activity in activities)
        {

            Console.WriteLine(activity.GetSummary());
        }
    }
}