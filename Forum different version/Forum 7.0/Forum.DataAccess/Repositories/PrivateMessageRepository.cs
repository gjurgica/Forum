using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public class PrivateMessageRepository : BaseRepository, IRepository<PrivateMessage>
    {
        public PrivateMessageRepository(ForumDbContext context) : base(context) { }
        public int Delete(string Id)
        {
            PrivateMessage privateMessage = _context.Messages.FirstOrDefault(pm => pm.Id == Id);

            if (privateMessage == null)
            {
                return -1;
            }

            _context.Remove(privateMessage);
            return _context.SaveChanges();
        }

        public IEnumerable<PrivateMessage> GetAll()
        {
            return _context.Messages;
        }

        public PrivateMessage GetById(string Id)
        {
            return _context.Messages.FirstOrDefault(pm => pm.Id == Id);
        }

        public int Insert(PrivateMessage entity)
        {
            _context.Messages.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(PrivateMessage entity)
        {
            PrivateMessage privateMessage = _context.Messages.FirstOrDefault(pm => pm.Id == entity.Id);

            privateMessage.Content = entity.Content;

            return _context.SaveChanges();
        }
    }
}
