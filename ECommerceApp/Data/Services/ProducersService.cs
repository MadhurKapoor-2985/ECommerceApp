using ECommerceApp.Data.Base;
using ECommerceApp.Models;

namespace ECommerceApp.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }

    }
}
