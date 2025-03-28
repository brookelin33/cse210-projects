using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1.CommentText = "LOL this was so relatable";
        comment1.Commenter = "David Thomas";

        Comment comment2 = new Comment();
        comment2.CommentText = "I love this video!";
        comment2.Commenter = "Matthew Jones";

        Comment comment3 = new Comment();
        comment3.CommentText = "Thanks for the tips!";
        comment3.Commenter = "Cole Saunders";

        Comment comment4 = new Comment();
        comment4.CommentText = "I need part 2!!";
        comment4.Commenter = "Porter Anderson";

        Comment comment5 = new Comment();
        comment5.CommentText = "I love all your videos thank you!";
        comment5.Commenter = "Anna Brown";

        Comment comment6 = new Comment();
        comment6.CommentText = "Any advice on figuring out a budget?";
        comment6.Commenter = "Sarah Williams";

        Comment comment7 = new Comment();
        comment7.CommentText = "This is a solid list!";
        comment7.Commenter = "Jack Black";

        Comment comment8 = new Comment();
        comment8.CommentText = "I'm planning a trip this summer!";
        comment8.Commenter = "Emily Davis";

        Comment comment9 = new Comment();
        comment9.CommentText = "Such a great video!!";
        comment9.Commenter = "Liam Green";

        List <Video> videos = new List<Video>();
        Video video1 = new Video();
        video1.Title = "The Ultimate Guide To College Life";
        video1.Author = "Bob Smith";
        video1.Length = 10;
        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);


        Video video2 = new Video();
        video2.Title = "Wedding Tips and Tricks";
        video2.Author = "Sally Johnson";
        video2.Length = 5;
        video2.Comments.Add(comment4);
        video2.Comments.Add(comment5);
        video2.Comments.Add(comment6);

        Video video3 = new Video();
        video3.Title = "The Best Places To Visit In Canada";
        video3.Author = "John Miller";
        video3.Length = 15;
        video3.Comments.Add(comment7);
        video3.Comments.Add(comment8);
        video3.Comments.Add(comment9);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        DisplayVideos(videos);
    }

    static void DisplayVideos(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length of video in seconds: {video.Length}");
            Console.WriteLine();
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"--{comment.Commenter}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }

}