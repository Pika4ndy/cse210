using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        // Video Creation
        Video defaultVideo = new Video();
        Video video0 = new Video("The Fundamentals of Physics", "Andrianarivo Andy", 4000);
        Video video1 = new Video("A literal Youtube Video", 1334);
        Video video2 = new Video(3600);

        // Comments creation
        Comment comment1 = new Comment("Someone", "Hey, I know that guy");
        Comment comment2 = new Comment("Cool video");
        Comment comment3 = new Comment("Elvis Presley", "Never Gonna Give You Up");

        Comment shortComment1 = new Comment("First!");
        Comment shortComment2 = new Comment("Nice");

        Comment longComment1 = new Comment("Dev101", "I really enjoyed the part where you explained the formula at 1:05. Could you make a part 2?");
        Comment longComment2 = new Comment("LearningToCode", "This cleared up so many questions I had! Subscribed.");

        Comment question1 = new Comment("Student_A", "What software did you use to animate this?");
        Comment question2 = new Comment("Is this still applicable in 2026?");

        Comment meme2 = new Comment("Lurker99", "Who is watching this in 2026?");

        Comment edgeCase2 = new Comment("1234567890");
        Comment edgeCase3 = new Comment("System", "Test comment -- please ignore.");

        // Comment implementation
        defaultVideo.AddComment(comment1);
        defaultVideo.AddComment(shortComment1);
        defaultVideo.AddComment(question1);

        video0.AddComment(comment2);
        video0.AddComment(shortComment2);
        video0.AddComment(longComment1);
        video0.AddComment(edgeCase2);

        video1.AddComment(comment3);


        video2.AddComment(question2);
        video2.AddComment(longComment2);
        video2.AddComment(meme2);
        video2.AddComment(edgeCase3);

        videoList.Add(defaultVideo);
        videoList.Add(video0);
        videoList.Add(video1);
        videoList.Add(video2);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine(video.GetDisplayComments() + "\n");
        }
    }
}