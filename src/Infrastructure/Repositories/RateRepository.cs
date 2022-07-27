using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class RateRepository : IRateRepository
    {
        private readonly AppDbContext _appDbContext;

        public RateRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Rate>? AllRates => _appDbContext.Rates;
    }
}
