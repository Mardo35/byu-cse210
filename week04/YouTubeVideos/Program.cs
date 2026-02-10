using System;

class Program
{
    static void Main(string[] args)
    {
    List<Video> videos = new List<Video>();

        // --- Video 1 ---
        Video v1 = new Video("C# for Beginners", "Baguidy Mardochee", 600);
        v1.AddComment(new Comment("Alice", "Great tutorial, thanks!"));
        v1.AddComment(new Comment("Bob", "I'm stuck on step 3."));
        v1.AddComment(new Comment("Charlie", "Very clear explanation."));
        videos.Add(v1);

        // --- Video 2 ---
        Video v2 = new Video("Are you willing to pay the price for greatness?", "@bridgesyt", 654);
        v2.AddComment(new Comment("@CryptoBroke", "Bro Calmly spoiled all Berserk"));
        v2.AddComment(new Comment("@crazygrizzy", "life without purpose is empty, but no purposes without balance can lead to ruin"));
        v2.AddComment(new Comment("@revasgamer7793", "The griffith example came from nowhere....subbed."));
        videos.Add(v2);

        // --- Video 3 ---
        Video v3 = new Video("This tool will help you improve your critical thinking", "TED Ed", 319);
        v3.AddComment(new Comment("@arcie3716", "oh, so when Socrates constantly asks questions, he is a philosopher but when i do, i am annoying😒"));
        v3.AddComment(new Comment("@riunosk", "gaining brain cells every time ted ed uploads."));
        v3.AddComment(new Comment("@gardenhead92", "The socratic method isn't for proving that you have the answer-it's to show the other person that they don't either. "));
        videos.Add(v3);

        // Displaying the Data
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: \"{comment._text}\"");
            }
            Console.WriteLine();
        }

















    }
}