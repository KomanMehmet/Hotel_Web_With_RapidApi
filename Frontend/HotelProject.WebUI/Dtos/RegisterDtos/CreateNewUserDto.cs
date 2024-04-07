using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDtos
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı alanı gereklidir.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail alanı gereklidir.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şehir alanı gereklidir.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Soyad Tekrar alanı gereklidir.")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ComfirmPassword { get; set; }
    }
}
