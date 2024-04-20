namespace HotelProject.DtoLayer.Dtos.ContactDtos
{
    public class GetByIdContactDto
    {
        public int ContactID { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}
