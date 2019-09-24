using Forum.DomainClasses.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DataAccess.Interfaces
{
    public interface IUserRepository<TUser> where TUser : IdentityUser
    {
        IEnumerable<TUser> GetAll();
        User GetByUsername(string username);
        User GetById(string Id);
        int Insert(TUser entity);
        int Update(TUser entity);
        int Delete(string id);
    }
}
