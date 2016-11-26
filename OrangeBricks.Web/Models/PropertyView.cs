using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    public class PropertyView
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string BuyerId { get; set; }

        public int PropertyId { get; set; }
    }
}