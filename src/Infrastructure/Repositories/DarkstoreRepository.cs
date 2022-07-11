using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class DarkstoreRepository : IDarkstoreRepository
    {
        private readonly AppDbContext _appDbContext;

        public DarkstoreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Darkstore>? AllDarkstores => _appDbContext.Darkstores;
    }
}
