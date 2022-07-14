using ECommerceApp.Data.Base;
using ECommerceApp.Models;

namespace ECommerceApp.Data.Services
{
    public class CinemasService: EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context): base(context) { }

    }
}
