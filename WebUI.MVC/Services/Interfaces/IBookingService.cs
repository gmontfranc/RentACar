using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebUI.MVC.Models;

namespace WebUI.MVC.Services.Interfaces
{
    public interface IBookingService
    {
        Task<Bookings> GetAllAsync(string accessToken);
        Task<Booking> CreateAsync(Booking booking, string accessToken);
        Task<Booking> BookingDetailsAsync(int? id);
        Task<Booking> UpdateBookingAsync(int? id, Booking booking);
        Task DeleteBookingAsync(int? id);
    }
}
