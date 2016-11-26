using System;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class BookViewViewModel
    {
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public DateTime Date { get; set; }
        public DateTime MinDate { get; set; }
        public int PropertyId { get; set; }
    }
}