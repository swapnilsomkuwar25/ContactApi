using Contacts.API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.API.Models;
using Contacts.API.Data;
using Contacts.API.Repository.Adapter;

namespace Contacts.API.Repository
{
    public class ContactRepository : IRepository<Contact>, IDisposable
    {
        ContactEntities dbContext = new ContactEntities();

        public List<Contact> GetAll()
        {
            var allContacts = dbContext.ContactDetails.Select(x => x).ToList();
            return ContactAdapter.AdaptContacts(allContacts);
        }

        public Contact GetById(int id)
        {
            var contact = dbContext.ContactDetails.FirstOrDefault(x => x.id.Equals(id));
            return ContactAdapter.AdaptContact(contact);
        }

        public void Add(Contact contact)
        {
            dbContext.ContactDetails.Add(new ContactDetail { firstname = contact.FirstName, lastname = contact.LastName, email = contact.Email, phone = contact.Phone, isactive = contact.IsActive });
            dbContext.SaveChanges();
        }

        public void Update(Contact contact)
        {
            var item = dbContext.ContactDetails.Where(x => x.id.Equals(contact.Id)).Select(x => x).FirstOrDefault();
            item.firstname = contact.FirstName;
            item.lastname = contact.LastName;
            item.email = contact.Email;

            dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var item = dbContext.ContactDetails.Where(x => x.id.Equals(id)).Select(x => x).FirstOrDefault();
            dbContext.ContactDetails.Remove(item);
            dbContext.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                    dbContext = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
