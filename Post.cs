using System;

namespace Exercises
{
    public class Post
    {
        private static int _postId;
        private int _currPostId;
        private readonly string _question; // assume we cannot edit, sake of exercise
        private int _vote;
        // Assume each question is stored in a collection
        public int PostId
        {
            get { return _currPostId; }
        }
        public string Question
        {
            get { return _question; }
        }
        public Post(string question)
        {
            this._question = $"Q. {question}";
            this._currPostId = Post._postId +=1;
        }
        public int GetVote()
        {
            return this._vote;
        }
        public void DisplayPost()
        {
            Console.WriteLine("{0}\nID:{1}:{2}\nVotes: {3}", Question, _currPostId, PostId, this._vote);
        }
        // Debug
        //private int VoteStatus()
        //{
        //    Console.WriteLine("POST_ID {0} -Current post votes now: {1}", PostId, this._vote);
        //    return this._vote;
        //}
        public int Upvote()
        {
            return this._vote += 1;
        }
        public int DownVote()
        {
            return this._vote -= 1;
        }
    }
}
