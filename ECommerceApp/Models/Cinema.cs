using ECommerceApp.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Logo")]
        [Required(ErrorMessage ="Logo URL is required")]
        public string Logo { get; set; }
        [Display(Name="Name")]
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
