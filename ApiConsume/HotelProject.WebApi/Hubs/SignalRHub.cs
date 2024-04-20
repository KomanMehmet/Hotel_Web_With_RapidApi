using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.SignalR;

namespace HotelProject.WebApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly IBookingService _bookingService;

        public SignalRHub(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public async Task SendBookingList()
        {
            var sendBookingList = _bookingService.TGetList();

            await Clients.All.SendAsync("ReceiveBookingList", sendBookingList);
        }
    }
}
