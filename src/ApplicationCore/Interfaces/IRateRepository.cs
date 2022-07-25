using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IRateRepository
    {
        public IEnumerable<Rate>? AllRates { get; set; }
    }
}
