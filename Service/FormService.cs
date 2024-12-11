using Core.Models;
using Core.Repositories;
using Core.Services;

namespace Service
{
    public class FormService(IRepositoryManager repositoryManager) : IFormService
    {
        private readonly IRepositoryManager _repositoryManager = repositoryManager;

        public Form Add(Form user)
        {
            _repositoryManager.Forms.Add(user);
            _repositoryManager.Save();
            return user;
        }

        public void Delete(Form form)
        {
            _repositoryManager.Forms.Delete(form);
            _repositoryManager.Save();
        }

        public IEnumerable<Form> GetAll()
        {
            return _repositoryManager.Forms.GetAll();
        }

        public Form? GetById(int id)
        {
            return _repositoryManager.Forms.GetById(id);
        }

        public Form? Update(int id,Form form)
        {
            var updatedForm = GetById(id);
            if (updatedForm == null)
            {
                return null;
            }
            updatedForm.FirstName = form.FirstName;
            updatedForm.Email = form.Email;

            _repositoryManager.Forms.Update(updatedForm);
            _repositoryManager.Save();
            return updatedForm;
        }
    }
}