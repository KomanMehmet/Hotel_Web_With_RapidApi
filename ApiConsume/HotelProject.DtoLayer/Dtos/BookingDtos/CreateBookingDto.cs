﻿namespace HotelProject.DtoLayer.Dtos.BookingDtos
{
    public class CreateBookingDto
    {
        public string Name { get; set; }

        public string Mail { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public string AdultCount { get; set; }

        public string ChildCount { get; set; }

        public string RoomCount { get; set; }

        public string CustomerRequests { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}
