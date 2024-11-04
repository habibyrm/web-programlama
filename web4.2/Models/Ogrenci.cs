using System.ComponentModel.DataAnnotations;

namespace web4._2.Models
{
    public class Ogrenci
    {
        [Display(Name ="Öğrenci Ad")]
        [Required(ErrorMessage ="Öğrenci adını giriniz!")]
        public string OgrAd {  get; set; }
        [Display(Name = "Öğrenci Soyad")]
        [Required(ErrorMessage = "Öğrenci soyadını giriniz!")]
        public string OgrSoyad { get; set; }
        [Display(Name = "Öğrenci Numarası")]
        [Required(ErrorMessage = "Öğrenci numarasını giriniz!")]
        public string OgrNo { get; set; }
        [Display(Name = "Öğrenci Yaşı")]
        [Required(ErrorMessage = "Öğrenci yaşını giriniz!")]
        [Range(18,65,ErrorMessage ="Yaş aralığı 18-65 olmalıdır")]
        public int OgrYas { get; set; }
        [Display(Name = "Öğrencinin Doğum Tarihi")]
        [Required(ErrorMessage = "Öğrenci doğum tarihini giriniz!")]
        public DateTime OgrDTarih { get; set; }
    }
}
