using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Models
{
    public class ShopModel
    {
        [Key]
        public int ShopId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string ShopName { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        [Required]
        public string ShopCountry { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [Required]
        public string ShopCurrency { get; set; }
    }
}
