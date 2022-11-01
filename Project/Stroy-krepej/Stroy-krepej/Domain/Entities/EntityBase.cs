using System;
using System.ComponentModel.DataAnnotations;

namespace Stroy_krepej.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Название(Заголовок)")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }

        [Display(Name = "Титульная страница")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO мататэг title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO метатэг Description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO метатэг Keywords")]
        public string MetaKeyWords { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
