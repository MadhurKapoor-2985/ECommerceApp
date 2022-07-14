using ECommerceApp.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture URL is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage ="Full Name is required")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        [Required(ErrorMessage ="Biography is required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; }

    }
}
