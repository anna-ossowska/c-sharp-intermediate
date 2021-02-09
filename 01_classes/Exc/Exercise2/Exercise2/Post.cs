using System;


namespace Exercise2
{
    public class Post
    {
        public string Title {get; private set;}
        public string Description {get; private set;}
        public DateTime Date {get; private set;}
        public int UpVotes { get; private set; }
        public int DownVotes { get; private set; }
        public int Count { get; private set; }


        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Date = DateTime.Now;
            this.UpVotes = 0;
            this.DownVotes = 0;
            this.Count = 0;

        }

        public string UpVote()
        {
            ++Count;
            ++UpVotes;
            return "You have upvoted the post.";

        }

        public string DownVote()
        {
            ++Count;
            --DownVotes;
            return "You have downvoted the post.";
        }

        public string Total()
        {
            return $"This post has {Count} votes.";

        }
    }
}
