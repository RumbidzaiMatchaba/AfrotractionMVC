using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FiveRosesTea.Models
{
    public class Product
    {
        [Required(ErrorMessage ="You must enter a Product ID")]
        [Display (Name ="Product ID")]
        [Range (100,999 ,ErrorMessage ="Enter Valid Product ID")]
        public int productID { get; set; }

        [Display(Name ="Description")]
        [Required(ErrorMessage = "You must enter a Product Desccription")]
        public String description { get; set; }

        [Display (Name ="Sizes")]
        [Required(ErrorMessage = "You must enter available Product Sizes")]
        public String size { get; set; }


        [Display(Name ="Price")]
        [Required(ErrorMessage = "You must enter a valid Product Price")]
        [Range(100, 999, ErrorMessage = "Enter Valid Product Price")]
        public double price { get; set; }
    }
}