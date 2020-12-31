using System.Collections.Generic;

namespace Exercises
{
    public class Posts
    {
        private readonly Dictionary<int,Post> _postList;
        public Dictionary<int,Post> PostList {
            get
            {
                return _postList;
            }
        }
        public Posts()
        {
            _postList = new Dictionary<int, Post>();
        }
    }
}
