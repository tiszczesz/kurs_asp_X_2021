using WebApiFirst.Data;

namespace WebApiFirst.Models
{
    public class SQLContactRepo : IContactRepo {
        private ContactDbContext _db;

        public SQLContactRepo(ContactDbContext db) {
            _db = db;
        }
        public IEnumerable<Contact> GetContacts() {
            return _db.Contacts.ToList();
        }

        public Contact GetContactById(int id) {
            return _db.Contacts.Find(id);
        }

        public IEnumerable<Contact> DeleteContact(int id) {
            var contact = _db.Contacts.Find(id);
            if (contact != null) _db.Contacts.Remove(contact);
            _db.SaveChanges();
            return _db.Contacts.ToList();
        }

        public IEnumerable<Contact> UpdateContact(int id, Contact contact) {
            var contactToUpdate = _db.Contacts.Find(id);
            if (contactToUpdate != null) {
                contactToUpdate.FirstName = contact.FirstName;
                contactToUpdate.LastName = contact.LastName;
                contactToUpdate.Phone = contact.Phone;
                contactToUpdate.Date = contact.Date;
                _db.SaveChanges();
            }

            return _db.Contacts.ToList();
        }

        public IEnumerable<Contact> AddContact(Contact contact) {
            _db.Contacts.Add(contact);
            _db.SaveChanges();
            return _db.Contacts.ToList();
        }
    }
}
