using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        // first video
        Video video1 = new Video();
        video1._title = "The Most Popular Video Ever";
        video1._author = "Mr. BigGuy";
        video1._lengthInSec = 600;
        Comment comment1 = new Comment();
        comment1._userName = "tweedledee";
        comment1._commentText = "This guy used to be good but now it's all clickbait.";
        video1._comments.Add(comment1);
        Comment comment2 = new Comment();
        comment2._userName = "dorp";
        comment2._commentText = "use this as your 'I got here before 1 mil views' button";
        video1._comments.Add(comment2);
        Comment comment3 = new Comment();
        comment3._userName = "mrbigguyofficial";
        comment3._commentText = "guys make sure to take a look at this week's sponsor, What's Up, Tasty and use my code for 37% off your first 900 meal pouches!";
        video1._comments.Add(comment3);
        videos.Add(video1);
        Console.Clear();

        // second video
        Video video2 = new Video();
        video2._title = "WHOLE MEAL From One Cardboard Box (emotional) | Bean Bean Mama";
        video2._author = "Bean Bean Mama";
        video2._lengthInSec = 900;
        Comment comment4 = new Comment();
        comment4._userName = "honey";
        comment4._commentText = "yum yum yum everything you make is the best thing that's ever been made!!!1!";
        video2._comments.Add(comment4);
        Comment comment5 = new Comment();
        comment5._userName = "foodboy";
        comment5._commentText = "Let's be honest, 'What's Up, Tasty' should have been called 'Hey There, Narsty'. Never buying from them. Sad to see one of my fave creators sell out.";
        video2._comments.Add(comment5);
        Comment comment6 = new Comment();
        comment6._userName = "beepbeepimajeep";
        comment6._commentText = "I guess we're just not gonna talk about the ghost at 3:48?";
        video2._comments.Add(comment6);
        videos.Add(video2);
        Console.Clear();

        //third video
        Video video3 = new Video();
        video3._title = "Bean Bean Mama's HAUNTED Channel";
        video3._author = "ConspiraSea Pirate";
        video3._lengthInSec = 700000;
        Comment comment7 = new Comment();
        comment7._userName = "honey";
        comment7._commentText = "ur just jealous that ur videos could never be as good as BBM! its true what they say about haters really gotta play the game or get out of the kitchen!";
        video3._comments.Add(comment7);
        Comment comment8 = new Comment();
        comment8._userName = "beepbeepimajeep";
        comment8._commentText = "THANK YOU I THOUGHT I WAS GOING CRAZY";
        video3._comments.Add(comment8);
        Comment comment9 = new Comment();
        comment9._userName = "whatYEARisit";
        comment9._commentText = "How is this video 183 hours long and it felt like 30 minutes. That's good content right there.";
        video3._comments.Add(comment9);
        Comment comment10 = new Comment();
        comment10._userName = "honey";
        comment10._commentText = "okay, after watching the whole thing I feel so betrayed. How did I not notice before that I'd been possessed by the same Sourdough ghost in the videos! That's why I loved BBM's videos so much....ugh\nNOW YOU'RE MY FAVEEEEE EVERYTHING YOU MAKE IS THE BEST THING THAT'S EVERY BEEN MAADDEEEEEE!!!!!!!1!!!";
        video3._comments.Add(comment10);
        videos.Add(video3);
        Console.Clear();


        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();

        }


    }
}