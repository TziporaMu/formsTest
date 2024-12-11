using Core.Models;
namespace Core.Repositories
{
    public interface IRepositoryManager
    {
        IRepository<Form> Forms { get; }

        void Save();
    }
}
