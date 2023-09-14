using Microsoft.AspNetCore.Mvc;

namespace ContactifyAPI.Services.ContactService
{
    public interface IContactService
    {
        Task<ActionResult<IEnumerable<Contact>>> GetContacts();
        Task<ActionResult<Contact>> GetContactById(int id);
        Task<ActionResult<Contact>> CreateContact(Contact contact);
        Task<IActionResult> UpdateContact(int id, Contact updatedContact);
        Task<IActionResult> DeleteContact(int id);
    }
}
