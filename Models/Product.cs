using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamTest.Models
{
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("price")]
        public int Price { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("discount")]
        public int Discount { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
