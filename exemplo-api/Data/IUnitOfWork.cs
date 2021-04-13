using System.Threading.Tasks;

namespace Exemplo.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}