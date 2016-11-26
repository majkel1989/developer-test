using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;
using System;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class BookViewViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public BookViewViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public BookViewViewModel Build(int id)
        {
            var property = _context.Properties.Find(id);

            return new BookViewViewModel
            {
                PropertyId = property.Id,
                PropertyType = property.PropertyType,
                StreetName = property.StreetName,
                MinDate = DateTime.Now
            };
        }
    }
}