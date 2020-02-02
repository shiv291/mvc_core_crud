using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.MVC.Models
{
    public class ProductViewModel
    {        
        public ProductViewModel()
        {
            Category = new List<KeyValueModel>();
            //Color = new List<KeyValueModel>();
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<KeyValueModel> Category { get; set; }
        [Required]
        public string ColorName { get; set; }
        //public List<KeyValueModel> Color { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public long AvailableQuantity { get; set; }
     
        [Display(Name = "Add a picture")]        
        [Required(ErrorMessage = "Please select photo")]
        public IFormFile ProductImage { get; set; }
        public string[] Companies { get; set; }

    }

    public class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

}
