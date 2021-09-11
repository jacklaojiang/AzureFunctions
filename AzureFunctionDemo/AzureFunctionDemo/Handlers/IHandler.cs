using System.Threading.Tasks;

namespace RealEstateManagement.Handlers
{
    public interface IHandler<T>
    {
        Task Handle(T value);
    }
}
