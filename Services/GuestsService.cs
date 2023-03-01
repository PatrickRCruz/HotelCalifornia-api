using HotelCalifornia.API.Context;
using HotelCalifornia.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelCalifornia.API.Services
{
    public class GuestsService : IGuestService
       
    {
        private readonly AppDbContext _context;

        public GuestsService(AppDbContext context)
        {
            _context = context;
        }

        public  async Task<IEnumerable<Guest>> GetGuests()
        {
            try
            {
                return await _context.Guests.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Guest>> GetGuestByName(string name)
        {
            IEnumerable<Guest> guests;
            if (!string.IsNullOrWhiteSpace(name)) 
            {
                guests = await _context.Guests.Where(n => n.Name.Contains(name)).ToListAsync();
            }
            else
            {
                guests = await GetGuests();
            }
            return guests;
        }
        public async Task<Guest> GetGuest(int Id)
        {
            var guest = await _context.Guests.FindAsync(Id);
            return guest;
        }
        public async Task CreateGuest(Guest guest)
        {
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateGuest(Guest guest)
        {
            _context.Entry(guest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteGuest(Guest guest)
        {
            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
        }

    }
}
