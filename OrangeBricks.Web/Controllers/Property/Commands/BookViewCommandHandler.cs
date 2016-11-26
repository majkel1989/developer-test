using System;
using System.Collections.Generic;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookViewCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public BookViewCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(BookViewCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var propertyView = new PropertyView
            {
                BuyerId = command.BuyerId,
                Date = command.Date,
                PropertyId = command.PropertyId
            };

            if (property.Views == null)
            {
                property.Views = new List<PropertyView>();
            }
                
            property.Views.Add(propertyView);
            
            _context.SaveChanges();
        }
    }
}