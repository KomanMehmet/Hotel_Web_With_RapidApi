﻿namespace HotelProject.WebUI.Dtos.RoomDtos
{
    public class CreateRoomDto
    {
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        public int Price { get; set; }

        public string RoomTitle { get; set; }

        public string BedCount { get; set; }

        public string BethCount { get; set; }

        public string WiFi { get; set; }

        public string RoomDescription { get; set; }
    }
}
