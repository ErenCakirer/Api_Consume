using System.ComponentModel.DataAnnotations;

namespace HotelProjectUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Servis İkonu Giriniz.")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz.")]
        public string Description { get; set; }
    }
}
