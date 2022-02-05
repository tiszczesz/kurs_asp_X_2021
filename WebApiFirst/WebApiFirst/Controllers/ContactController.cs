using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFirst.Models;

namespace WebApiFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase {
        private IContactRepo _contactRepo;

        public ContactController(IContactRepo contactRepo) {
            _contactRepo = contactRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contact>> Get() {
            var contacts = _contactRepo.GetContacts();
            if (contacts==null) {
                return BadRequest();
            }
            return Ok(contacts);
        }
        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            var contact = _contactRepo.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Contact>> Delete(int id) {
            
            return Ok(_contactRepo.DeleteContact(id));
        }

        [HttpPost]
        public ActionResult<IEnumerable<Contact>> Post(Contact contact) {
            return Ok(_contactRepo.AddContact(contact));
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Contact>> Put( int id,Contact contact) {
            return Ok(_contactRepo.UpdateContact(id, contact));
        }
    }
}
