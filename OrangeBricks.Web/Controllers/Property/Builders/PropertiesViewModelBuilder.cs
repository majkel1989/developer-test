using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;
using System.Data.Entity;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class PropertiesViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public PropertiesViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public PropertiesViewModel Build(PropertiesQuery query, string currentUserId)
        {
            var properties = _context.Properties
                .Where(p => p.IsListedForSale)
                .Include(i => i.Offers);

            if (!string.IsNullOrWhiteSpace(query.Search))
            {
                properties = properties.Where(x => x.StreetName.Contains(query.Search) 
                    || x.Description.Contains(query.Search));
            }

            return new PropertiesViewModel
            {
                Properties = properties
                    .ToList()
                    .Select(p => MapViewModel(p, currentUserId))
                    .ToList(),
                Search = query.Search
            };
        }

        private static PropertyViewModel MapViewModel(Models.Property property, string currentUserId)
        {
            return new PropertyViewModel
            {
                Id = property.Id,
                StreetName = property.StreetName,
                Description = property.Description,
                NumberOfBedrooms = property.NumberOfBedrooms,
                PropertyType = property.PropertyType,
                IsCurrentUserOfferAccepted = property.Offers
                    .Any(o => o.Status == OfferStatus.Accepted && o.BuyerId == currentUserId)
            };
        }
    }
}