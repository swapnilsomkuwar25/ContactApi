using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contacts.API.Models;

namespace Contacts.API.Repository.Interface
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(Contact contact);
        void Delete(int id);
        void Update(Contact contact);        
    }
}