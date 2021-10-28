using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModelCarMVC.Models
{
    public class Car
    {
        //primary key
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Year { get; set; }

        [Required]
        public int Milage { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [Display(Name = "New?")]
        public bool Condition { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Image of Car")]
        public IFormFile ImageFile { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }


        public DateTime Created { get; set; }

        public virtual IdentityUser User { get; set; }

    }
}
