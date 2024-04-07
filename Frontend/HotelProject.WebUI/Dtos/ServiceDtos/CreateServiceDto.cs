using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Servis Icon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Servis için bir başlık giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakterden oluşmalıdır")]
        public string ServiceTitle { get; set; }

        [Required(ErrorMessage = "Servis için bir açıklama giriniz")]
        public string ServiceDescription { get; set; }
    }
}
