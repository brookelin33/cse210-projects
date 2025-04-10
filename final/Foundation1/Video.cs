public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    public List<Comment> Comments { get; set; } = new List<Comment>();

    public int GetNumberOfComments() => Comments.Count;
}

