using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDtos
{
    public class CreateRoomDto
    {
        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz")]
        public string RoomNumber { get; set; }

        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Bilgisi Giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz")]
        public string RoomTitle { get; set; }

        [Required(ErrorMessage = "Lütfen Yatak Sayısını Giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen Banyo Sayısını Giriniz")]
        public string BethCount { get; set; }

        public string WiFi { get; set; }

        public string RoomDescription { get; set; }
    }
}
