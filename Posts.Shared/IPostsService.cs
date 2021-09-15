using JokePosts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokePosts.Shared
{
    public interface IPostsService
    {
        public List<Post> getAllPosts();
    }
}
