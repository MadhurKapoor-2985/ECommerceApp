using ECommerceApp.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="ProfilePictureURL is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="FullName is required")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage ="Bio is required")]
        public string Bio { get; set; }

        //Relation
        public List<Movie> Movies { get; set; }
    }
}
