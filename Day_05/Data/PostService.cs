using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_05.Data
{
    public class PostService
    {
        private readonly ApplicationDbContext _db;
        public PostService(ApplicationDbContext db)
        {
            this._db = db;
        }
        public List<Post> getAllPost()
        {
            var post = _db.Posts.ToList();
            return post;
        }

        public bool AddPost(Post post)
        {
            _db.Posts.Add(post);
            _db.SaveChanges();
            return true;
        }

        public Post getById(int id)
        {
            var post = _db.Posts.FirstOrDefault(x => x.PostId == id);
            return post;
        }

        public Post UpdatePost(Post post)
        {
            _db.Posts.Update(post);
            _db.SaveChanges();

            return post;
        }
    }
}
