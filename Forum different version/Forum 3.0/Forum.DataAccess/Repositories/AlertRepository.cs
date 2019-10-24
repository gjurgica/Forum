using Forum.DataAccess.Interfaces;
using Forum.DomainClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public class AlertRepository : BaseRepository, IRepository<Alert>
    {
        public AlertRepository(ForumDbContext context) : base(context) { }

        public int Delete(string Id)
        {
            Alert alert = _context.Alerts.FirstOrDefault(a => a.Id == Id);

            if (alert == null)
            {
                return -1;
            }

            _context.Alerts.Remove(alert);

            return _context.SaveChanges();
        }

        public IEnumerable<Alert> GetAll()
        {
            return _context.Alerts;
        }

        public Alert GetById(string Id)
        {
            return _context.Alerts.FirstOrDefault(a => a.Id == Id);
        }

        public int Insert(Alert entity)
        {
            _context.Alerts.Add(entity);
            return _context.SaveChanges();
        }

        public int Update(Alert entity)
        {
            _context.Alerts.Update(entity);
            return _context.SaveChanges();
        }
    }
}
