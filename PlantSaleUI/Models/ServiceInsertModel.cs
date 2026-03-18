using System.ComponentModel.DataAnnotations;

namespace PlantSaleUI.Models
{
    public class ServiceInsertModel
    {
        [Display]
        [Required(ErrorMessage ="Başlık Boş Olmamalı")]
        public string? Title { get; set; }

        [Display]
        [Required(ErrorMessage = "Açıklama Boş Olmamalı")]
        public string? Desc { get; set; }

        [Display]
        [Required(ErrorMessage = "Görsel Giriniz")]
        public string? Image { get; set; }    
    }
}
