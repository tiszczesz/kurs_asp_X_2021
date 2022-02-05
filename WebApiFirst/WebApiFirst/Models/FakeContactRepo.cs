namespace WebApiFirst.Models
{
    public class FakeContactRepo : IContactRepo
    {
        private List<Contact> _contacts;

        public FakeContactRepo() {
            _contacts = new List<Contact> {
                new Contact{Id = 1,FirstName = "Adam",LastName = "Nowak",
                    Date = new DateTime(2021,9,12),Phone = "122323232"},
                new Contact{Id = 2,FirstName = "Monika",LastName = "Małecka",
                    Date = new DateTime(2021,3,22),Phone = "4433333"},
                new Contact{Id = 3,FirstName = "Teresa",LastName = "Tur",
                    Date = new DateTime(2020,12,12),Phone = "555533333"},
                new Contact{Id = 4,FirstName = "Tomasz",LastName = "Bomasz",
                    Date = new DateTime(2020,5,21),Phone = "467777777"}
            };
        }
        public IEnumerable<Contact> GetContacts() {
            return _contacts;
        }

        public Contact GetContactById(int id) {
            return _contacts.Find(c => c.Id == id);
        }

        public IEnumerable<Contact> DeleteContact(int id) {
            Contact contact = _contacts.Find(c => c.Id == id);
            if (contact != null) {
                _contacts.Remove(contact);
            }

            return _contacts;
        }

        public IEnumerable<Contact> UpdateContact(int id, Contact contact) {
            Contact contactToUpdate = _contacts.Find(c => c.Id == id);
            if (contactToUpdate != null) {
                contactToUpdate.FirstName = contact.FirstName;
                contactToUpdate.LastName = contact.LastName;
                contactToUpdate.Date = contact.Date;
                contactToUpdate.Phone = contact.Phone;
            } 
            return _contacts;
        }

        public IEnumerable<Contact> AddContact(Contact contact) {
            _contacts.Add(contact);
            return _contacts;
        }
    }
}
