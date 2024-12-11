using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_formService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_formService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Form form)
        {
            return Ok(_formService.Add(form));
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Form form)
        {
            return Ok(_formService.Update(id, form));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var form = _formService.GetById(id);
            if (form is null)
            {
                return NotFound();
            }
            _formService.Delete(form);
            return NoContent();
        }
    }
}