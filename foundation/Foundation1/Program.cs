using System;

class Program
{
    static void Main(string[] arge)
    {
        List<Video> videos = new List<Video>
        {
            new Video("Video title 1", 25, "Author 1"),
            new Video("Video title 2", 50, "Author 2"),
            new Video("Video title 3", 75, "Author 3"),
        };

        videos[0].AddComment(new Comments("Commenter 1 ", "You did a great job"));
        videos[0].AddComment(new Comments("Commenter 2 ", "huuummmm, try again"));
        videos[0].AddComment(new Comments("Commenter 3 ", "excellent"));
        videos[0].AddComment(new Comments("Commenter 4 ", "interesting"));

        videos[1].AddComment(new Comments("Commenter 1 ", "great job"));
        videos[1].AddComment(new Comments("Commenter 2 ", "Not bad"));
        videos[1].AddComment(new Comments("Commenter 3 ", "good"));


        videos[2].AddComment(new Comments("Commenter 1 ", "You did it!!!!!"));
        videos[2].AddComment(new Comments("Commenter 2 ", "super"));
        videos[2].AddComment(new Comments("Commenter 3 ", "oh, i see"));
        videos[2].AddComment(new Comments("Commenter 4 ", "interesting"));

        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine("The number of comments is :" + video.NumComents());
            Console.WriteLine();
        }


    }
}