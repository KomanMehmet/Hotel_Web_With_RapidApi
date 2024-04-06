using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDtos
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarasını Giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Görselini Giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Fiyatını Giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Başlığını Giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen En Fazla 100 Karakter Veri Girişi Yapınız")]
        public string RoomTitle { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Yatak Sayısını Giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Banyo Sayısını Giriniz")]
        public string BethCount { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Wİ-Fİ Bilgisini Giriniz")]
        public string WiFi { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Açıklamasını Giriniz")]
        public string RoomDescription { get; set; }
    }
}
