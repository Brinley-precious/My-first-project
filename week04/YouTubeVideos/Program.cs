using System;

class Program
{
    static void Main(string[] args)
    {
        // Create list to store videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("The Power of Abstraction", "CS Professor", 300);
        video1.AddComment(new Comment("Jane", "This made abstraction so clear!"));
        video1.AddComment(new Comment("Mike", "Loved the real-world examples."));
        video1.AddComment(new Comment("Alice", "Great teaching style."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Understanding Encapsulation", "Tech With Tina", 450);
        video2.AddComment(new Comment("Sarah", "I finally understand private fields!"));
        video2.AddComment(new Comment("David", "Super helpful!"));
        video2.AddComment(new Comment("Leo", "Can you do one on inheritance?"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How YouTube Works Behind the Scenes", "CodeExplained", 600);
        video3.AddComment(new Comment("Emily", "This was fascinating."));
        video3.AddComment(new Comment("Chris", "More videos like this, please!"));
        video3.AddComment(new Comment("Sam", "Now I want to build my own YouTube clone."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Design Principles in OOP", "Dev Insights", 520);
        video4.AddComment(new Comment("Anna", "SOLID principles explained well."));
        video4.AddComment(new Comment("George", "Very informative."));
        video4.AddComment(new Comment("Nina", "Perfect revision before exams."));
        videos.Add(video4);

        // Display each video and its comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (sec): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}
