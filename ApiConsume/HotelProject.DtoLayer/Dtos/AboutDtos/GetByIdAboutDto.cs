namespace HotelProject.DtoLayer.Dtos.AboutDtos
{
    public class GetByIdAboutDto
    {
        public int AboutID { get; set; }

        public string AboutTitle1 { get; set; }

        public string AboutTitle2 { get; set; }

        public string AboutContent { get; set; }

        public int RoomCount { get; set; }

        public int StaffCount { get; set; }

        public int CustomerCount { get; set; }
    }
}
