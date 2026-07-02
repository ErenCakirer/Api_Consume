using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lütfen Oda No Girin.")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen Fiyat Girin.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Bilgisi Girin.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Girin.")]
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
