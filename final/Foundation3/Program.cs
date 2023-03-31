using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture l1 = new Lecture(new Address("1209 S Main St", "Grapevine", "TX", 76051),"Lecture", "Conversations", "A heartwarming speech by Dr. McDonald", "Oct 23, 2023", "7PM CST", "Dr. Kaila McDonald", 900);
        Console.WriteLine(l1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(l1.LectureDetails());
        Console.WriteLine();
        Console.WriteLine(l1.ShortDetails());
        Console.WriteLine();

        Reception r1 = new Reception(new Address("222 Betchan Dr", "Lake Dallas", "TX", 75065), "Reception", "Joey and Joanna's Reception", "Come celebrate Joe+Jo's marriage!", "Nov 9, 2023", "8PM CST", "joeplusjo@gmail.com");
        Console.WriteLine(r1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(r1.ReceptionDetails());
        Console.WriteLine();
        Console.WriteLine(r1.ShortDetails());
        Console.WriteLine();

        Outdoor o1 = new Outdoor(new Address("9750 E Upper, Gros Ventre Rd", "Kelly", "WY", 83011),"Outdoor", "Jimston Family Reunion", "One week of fun that's just as crazy as Uncle Bippy", "June 8 - 15, 2024", "8AM MST", "warm but windy with lows in the mid 40s and highs in the 90s");
        Console.WriteLine(o1.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(o1.OutdoorDetails());
        Console.WriteLine();
        Console.WriteLine(o1.ShortDetails());
        Console.WriteLine();
    }
}