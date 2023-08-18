﻿using eTicket.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Pictrue URL")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="FullName must be between 3 and 50)")]
        public string FullName { get; set; }

        [Display(Name = "Bigrophy")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationship
        public List<Actor_Movie> Actor_Movies { get; set; } = new List<Actor_Movie>();

    }
}

