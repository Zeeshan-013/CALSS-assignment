using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Order_CRUD.Models
{
    public class orders
    {

        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}
