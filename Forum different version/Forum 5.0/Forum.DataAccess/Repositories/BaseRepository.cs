using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DataAccess.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly ForumDbContext _context;

        public BaseRepository(ForumDbContext context)
        {
            _context = context;
        }
    }
}
