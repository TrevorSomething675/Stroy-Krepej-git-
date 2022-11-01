using System.ComponentModel.DataAnnotations;

namespace Stroy_krepej.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Инфомативная страница1";

        [Display(Name = "Содерждание страницы1")]
        public override string Text { get; set; } = "Содержимое заполняется администратором";
    }
}
