using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r1 = new Running("Running", "Mar 30 2023", 30, 3);
        activities.Add(r1);
        Swimming s1 = new Swimming("Swimming", "Apr 01 2023", 60, 100);
        activities.Add(s1);
        Biking b1 = new Biking("Biking", "Apr 02 2023", 30, 5, 30);
        activities.Add(b1);

        foreach (Activity activity in activities)
        {
            activity.GetSummary(activity.Distance());
        }
    }
}