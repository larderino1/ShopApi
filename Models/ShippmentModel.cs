using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Models
{
  
    public class ShippmentModel
    {
        [Key]
        public int ShippmentId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserSurname { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserPhone { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string ShippmentAdress { get; set; }
        [Required]
        //office or building 
        public string ShippmentDestination { get; set; }
        [Required]
        public int PostOfficeNumber { get; set; }
        [Required]
        public string PostOfficeAdress { get; set; }
        [Required]
        public int ShippmentPrice { get; set; }
        [ForeignKey("ShopId")]
        public ShopModel Shop { get; set; }
        public int ShopId { get; set; }
    }

}
