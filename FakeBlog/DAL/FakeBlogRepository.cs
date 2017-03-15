using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FakeBlog.Models;

namespace FakeBlog.DAL
{
    public class FakeBlogRepository : IRepository
    {
        private FakeBlogContext context;
        public FakeBlogRepository()
        {
            Context = new FakeBlogContext();
        }

        public FakeBlogRepository(FakeBlogContext context)
        {
            Context = context;
        }

        public FakeBlogContext Context { get; set; }

        public void AddPost(string name, int postId)
        {
            throw new NotImplementedException();
        }

        public void AddPost(string name, Author author)
        {
            throw new NotImplementedException();
        }

        public bool AttachUser(string userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int postId)
        {
            throw new NotImplementedException();
        }

        public bool RemovePost(int postId)
        {
            throw new NotImplementedException();
        }
    }
}