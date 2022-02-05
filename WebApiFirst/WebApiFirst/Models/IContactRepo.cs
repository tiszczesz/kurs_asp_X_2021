namespace WebApiFirst.Models
{
    public interface IContactRepo {
        IEnumerable<Contact> GetContacts();// GET

        Contact GetContactById(int id);   //GET

        IEnumerable<Contact> DeleteContact(int id);  //DELETE

        IEnumerable<Contact> UpdateContact(int id, Contact contact); //PUT

        IEnumerable<Contact> AddContact(Contact contact);   //POST
        
    }
}
