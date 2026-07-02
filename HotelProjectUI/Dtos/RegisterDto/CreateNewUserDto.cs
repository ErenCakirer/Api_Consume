using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad  Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı  Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail  Gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre  Gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Gereklidir")]
        public string ConfirmPassword { get; set; }


    }
}
