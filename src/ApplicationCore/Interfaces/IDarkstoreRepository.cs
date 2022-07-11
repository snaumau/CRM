using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IDarkstoreRepository
    {
        IEnumerable<Darkstore>? AllDarkstores { get; }
    }
}
