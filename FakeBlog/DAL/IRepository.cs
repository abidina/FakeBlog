using FakeBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBlog.DAL
{
    interface IRepository
    {
        //Create
        void AddPost(string name, Author author);
        void AddPost(string name, int postId);
        void AddDraft(string name, int draftId);

        //Read
        Post GetPost(int postId);

        //Update
        bool AttachUser(string userId, int postId); // true: successful, false: not successful

        //Delete
        bool RemovePost(int postId);
    }
}
