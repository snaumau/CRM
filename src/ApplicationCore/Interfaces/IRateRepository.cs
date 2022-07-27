using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IRateRepository
    {
        IEnumerable<Rate>? AllRates { get; }
    }
}
