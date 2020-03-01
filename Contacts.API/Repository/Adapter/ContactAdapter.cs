using Contacts.API.Data;
using Contacts.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contacts.API.Repository.Adapter
{
    public class ContactAdapter
    {
        /// <summary>
        /// Converts ContactsDetails list object to Contact list
        /// </summary>
        /// <param name="contactDetailsList"></param>
        /// <returns></returns>
        public static List<Contact> AdaptContacts(List<ContactDetail> contactDetailsList)
        {
            var result = new List<Contact>();
            foreach (var item in contactDetailsList)
            {
                result.Add(new Contact 
                { 
                    Id = item.id,
                    FirstName = item.firstname,
                    LastName = item.lastname,
                    Email = item.email,
                    Phone = item.phone,
                    IsActive = item.isactive
                });
            }
            return result;
        }

        /// <summary>
        /// Converts ContactDetails object to Contact object
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public static Contact AdaptContact(ContactDetail contact)
        {
            var result = new Contact {
                Id = contact.id,
                FirstName = contact.firstname,
                LastName = contact.lastname,
                Email = contact.email,
                Phone = contact.phone,
                IsActive = contact.isactive
            };
            
            return result;
        }
    }
}