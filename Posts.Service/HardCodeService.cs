using JokePosts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JokePosts.Shared;

namespace JokePosts.Service
{
    public class HardCodeService : IPostsService
    {
        public List<Post> getAllPosts()
        {
            var posts = new List<Post>();

            for(int i = 0; i < 10; i++)
            {
                var post = new Post() { 
                    Id = i,
                    Link = $"Sample {i}",
                    Name = $"Name {i}"
                };

                posts.Add(post);

            }

            return posts;
        }
    }
}
