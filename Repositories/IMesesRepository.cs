using Admin.Cuentas.Models;

namespace Admin.Cuentas.Repositories
{
    public interface IMesesRepository
    {
        Task<Meses> Create(Meses item);
        Task<bool> Delete(Meses item);
        Task<IEnumerable<Meses>> GetAll();
        Task<Meses> GetById(long id);
        Task<Meses> Update(Meses item);
    }
}