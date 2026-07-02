using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adınızı Girin.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre Girin.")]
        public string Password { get; set; }
    }
}
