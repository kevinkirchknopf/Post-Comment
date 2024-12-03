using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Comment_Libary
{
    public interface IAppServices
    {
        public void AddPost(Post post);
        public Post GetPost(int id);
        public void DeletePost(int id);
        public void UpdatePost(Post post);
        public List<Post> GetPosts();
        
        public void AddComment(Comment comment);

        public void DeleteComment(Comment comment);

            

    }
}
