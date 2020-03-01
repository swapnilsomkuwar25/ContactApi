using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Contacts.API.Models;
using Contacts.API.Repository.Interface;

namespace Contacts.API.Controllers
{
    /// <summary>
    /// Contact controller class
    /// </summary>
    public class ContactController : ApiController
    {
        IRepository<Contact> repository;
        public ContactController(IRepository<Contact> repository)
        {
            this.repository = repository;
        }

        // GET: api/Contact
        /// <summary>
        /// Returns the list of contacts
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Contact> Get()
        {
            var contacts = repository.GetAll();       
            return contacts;
        }

        // GET: api/Contact/5
        /// <summary>
        /// Return contact based on ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult Get(int id)
        {
            var contact = repository.GetById(id);
            return Ok(contact);
        }

        // POST: api/Contact
        /// <summary>
        /// Add new contact record
        /// </summary>
        /// <param name="contact"></param>
        public void Post([FromBody]Contact contact)
        {
            repository.Add(contact);
        }

        // PUT: api/Contact/5
        /// <summary>
        /// Update contact record
        /// </summary>
        /// <param name="contact"></param>
        public void Put([FromBody]Contact contact)
        {
            repository.Update(contact);
        }

        // DELETE: api/Contact/5
        /// <summary>
        /// Delete contact
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
