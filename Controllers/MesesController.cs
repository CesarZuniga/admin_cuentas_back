using Admin.Cuentas.Models;
using Admin.Cuentas.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Cuentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesesController : Controller
    {
        private readonly IMesesRepository _mesesRepository;

        public MesesController(IMesesRepository mesesRepository)
        {
            _mesesRepository = mesesRepository;
        }
        [HttpGet]
        public Task<IEnumerable<Meses>> GetMeses()
        {
            return _mesesRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Task<Meses> GetById(long id)
        {
            return _mesesRepository.GetById(id);
        }
        [HttpPost]
        public Task<Meses> Create(Meses item) 
        {
            return _mesesRepository.Create(item);
        }
        [HttpPut]
        public Task<Meses> Update(Meses item)
        {
            return _mesesRepository.Update(item);
        }
        [HttpDelete]
        public Task<bool> Delete(Meses item)
        {
            return _mesesRepository.Delete(item);
        }
    }
}
