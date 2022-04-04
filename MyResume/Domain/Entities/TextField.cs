using System.ComponentModel.DataAnnotations;

namespace MyResume.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required(ErrorMessage ="Заполните пустое поле")]
        public string CodeWord { get; set; }

        [Display(Name = "Название(заголовок)")]
        public override string Title { get; set; } //= "Информационная страница";

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } //= "содержание заполяется администратором";

    }
}
