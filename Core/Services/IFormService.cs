using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IFormService
    {
        IEnumerable<Form> GetAll();

        Form? GetById(int id);

        Form Add(Form Form);

        Form? Update(int id, Form Form);

        void Delete(Form Form);
    }
}
