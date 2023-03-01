using HotelCalifornia.API.Models;

namespace HotelCalifornia.API.Services
{
    public interface IGuestService
    {
        Task<IEnumerable<Guest>> GetGuests();
        Task<Guest> GetGuest(int Id);
        Task<IEnumerable<Guest>> GetGuestByName(string Name);
        Task CreateGuest (Guest guest);
        Task UpdateGuest(Guest guest);
        Task DeleteGuest(Guest guest);
        
    }
}
