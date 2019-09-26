using ForumDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumDataAccess.Interfaces
{
    public interface IPostRepository<T> : IRepository<T>
    {
        IEnumerable<T> GetPostsByThread(int id);
    }
}
