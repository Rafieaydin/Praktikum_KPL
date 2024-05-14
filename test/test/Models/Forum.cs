namespace test.Models
{
    public class Forum
    {
        public int id_post { get; set; }
        public string title { get; set; }
        public string content { get; set; } 
        public string created_at { get; set; }
        public Comment[] comments { get; set; }
    }

    public class Comment
    {
        public int id_commentid { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
    }
}
