using System.ComponentModel.DataAnnotations;

namespace MyResume.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required]
        [Display(Name = "Название компании")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание стажа")]
        public override string Subtitle { get; set; }
        
        [Display(Name = "Полное описание стажа")]
        public override string Text { get; set; }
    }
}
