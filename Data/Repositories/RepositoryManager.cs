using Core.Models;
using Core.Repositories;

namespace Data.Repositories
{
    public class RepositoryManager(DataContext context, IRepository<Form> formRepository) : IRepositoryManager
    {
        private readonly DataContext _context = context;
        public IRepository<Form> Forms => formRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
