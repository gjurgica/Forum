using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumDataAccess.Repositories
{
    public class BaseRepository<TDbContext>
        where TDbContext : DbContext
    {
        protected readonly TDbContext _context;
        public BaseRepository(TDbContext context)
        {
            _context = context;
        }
    }
}
