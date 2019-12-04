using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApi.Models
{
    public class ItemModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public string ItemDescription { get; set; }
        [ForeignKey("ShopId")]
        public ShopModel Shop { get; set; }
        public int ShopId { get; set; }
    }
}
