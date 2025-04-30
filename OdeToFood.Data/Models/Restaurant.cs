using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        //[RegularExpression("")]
        //[Range(0, int.MaxValue)]
        public string Name { get; set; }

        //[DisplayFormat(DataFormatString = "text")]
        //[DisplayFormat(NullDisplayText = "goo")]
        //[DataType(DataType.Password)]
        [Display(Name= "Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
