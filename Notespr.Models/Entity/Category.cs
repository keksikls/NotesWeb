using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notespr.Models.Entity
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(15 , ErrorMessage ="Вы вышли за границу")]
        public string? Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,20 , ErrorMessage = " Вы вышли за границу")]
        public int DisplayOrder { get; set; }

    }
}
