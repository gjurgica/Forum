using ForumDataAccess.Interfaces;
using ForumDomain;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForumDataAccess.Repositories
{
    public class PostReplyRepository : IPostReplyRepository
    {
        private ForumDbContext _context;
        public PostReplyRepository(ForumDbContext context)
        {
            _context = context;
        }
        public void AddReply(PostReply reply)
        {
            _context.Replies.Add(reply);
            _context.SaveChanges();
        }

        public void DeleteReply(int id)
        {
            var deleted = _context.Replies.FirstOrDefault(x => x.Id == id);
            if(deleted != null)
            {
                _context.Replies.Remove(deleted);
                _context.SaveChanges();
            }
        }

        public void EditReply(PostReply reply)
        {
            var edit = _context.Replies.FirstOrDefault(x => x.Id == reply.Id);
            if(edit != null)
            {
                var index = _context.Replies.IndexOf(edit);
                _context.Replies.ToList()[index] = reply;
                _context.SaveChanges();
            }
        }

        public IEnumerable<PostReply> GetAllReplies()
        {
            return _context.Replies.ToList();
        }

        public PostReply GetReplyById(int id)
        {
            return _context.Replies.FirstOrDefault(x => x.Id == id);
        }
    }
}
