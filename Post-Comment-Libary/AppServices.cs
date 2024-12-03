using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Comment_Libary
{
    

    public class AppServices : IAppServices
    {
        public readonly Context Context;

        public AppServices()
        {
            Context = new Context();
        }
        public void AddComment(Comment comment)
        {
            Context.Add(comment);
            Context.SaveChanges();
        }

        public void AddPost(Post post)
        {
            Context.Add(post);
            Context.SaveChanges();
        }

        public void DeleteComment(Comment comment)
        {
            Context.Remove(comment);
        }

        public void DeletePost(int id)
        {
            var Delpost = (from x in Context.Posts where x.Id == id select x).FirstOrDefault();
            Context.Remove(Delpost);
            Context.SaveChanges();
        }

        public Post GetPost(int id)
        {
            var getPost = (from x in Context.Posts where x.Id == id select x).FirstOrDefault();
            return getPost;
            
        }

        public List<Post> GetPosts()
        {
            var GetPosts = from x in Context.Posts select x;
            return GetPosts.ToList();
        }

        public void UpdatePost(Post post)
        {
           var updatePost = (from x in Context.Posts where x.Id == post.Id select x).FirstOrDefault();
           Context.Update(updatePost);
           Context.SaveChanges();
        }
    }
}
