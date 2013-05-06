using System.Linq;
using System.Web.Http;
using Breeze.WebApi;
using BreezeExample.Models;
using Newtonsoft.Json.Linq;

namespace BreezeExample.Controllers.api
{
    [BreezeController]
    public class AdventureWorksController : ApiController
    {
        private readonly EFContextProvider<AdventureWorksContext> _ContextProvider =
                new EFContextProvider<AdventureWorksContext>();

        // ~/api/AdventureWorks/Metadata 
        [HttpGet]
        public string Metadata()
        {
            return _ContextProvider.Metadata();
        }

        // ~/api/AdventureWorks/Addresses
        [HttpGet]
        public IQueryable<Address> Addresses()
        {
            return _ContextProvider.Context.Addresses;
        }

        // ~/api/AdventureWorks/Customers
        [HttpGet]
        public IQueryable<Customer> Customers()
        {
            return _ContextProvider.Context.Customers;
        }

        // ~/api/AdventureWorks/Customers
        [HttpGet]
        public IQueryable<Product> Products()
        {
            return _ContextProvider.Context.Products;
        }

        // ~/api/AdventureWorks/Categories
        [HttpGet]
        public IQueryable<vGetAllCategory> Categories()
        {
            return _ContextProvider.Context.vGetAllCategories;
        }


        // ~/api/AdventureWorks/SaveChanges
        [HttpPost]
        public SaveResult SaveChanges( JObject saveBundle )
        {
            return _ContextProvider.SaveChanges( saveBundle );
        }
    }
}

