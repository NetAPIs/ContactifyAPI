using ContactifyAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactifyAPI.Services.ContactService
{
    public class ContactService : IContactService
    {
        private readonly DataContext _context;

        public ContactService(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Contact>> CreateContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return contact;
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return null;
            }

            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();

            return null;
        }

        public async Task<ActionResult<Contact>> GetContactById(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return null;
            }

            return contact;
        }

        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<IActionResult> UpdateContact(int id, Contact updatedContact)
        {
            if (id != updatedContact.Id)
            {
                return null;
            }

            _context.Entry(updatedContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Contacts.Any(c => c.Id == id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return null;
        }
    }
}
