using System;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookViewCommand
    {
        public int PropertyId { get; set; }

        public DateTime Date { get; set; }

        public string BuyerId { get; set; }
    }
}