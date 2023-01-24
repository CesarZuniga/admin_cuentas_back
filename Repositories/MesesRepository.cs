using Admin.Cuentas.Data;
using Admin.Cuentas.Models;
using Microsoft.EntityFrameworkCore;

namespace Admin.Cuentas.Repositories
{
    public class MesesRepository : IMesesRepository
    {
        private readonly SQLiteContext _context;

        public MesesRepository(SQLiteContext context)
        {
            _context = context;
        }
        public async Task<Meses> Create(Meses item)
        {
            var lastElement = await _context.Meses.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            long id = lastElement != null ? lastElement.Id + 1 : (long)1;
            item.Id = id;
            await _context.Meses.AddAsync(item);
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
            return item;
        }
        public async Task<IEnumerable<Meses>> GetAll()
        {
            return await Task.FromResult(_context.Meses.Where(x => true));
        }
        public async Task<Meses> GetById(long id)
        {
            return (await _context.Meses.FirstOrDefaultAsync(x => x.Id == id))!;
        }
        public async Task<Meses> Update(Meses item)
        {
            Meses elementU = (await _context.Meses.FirstOrDefaultAsync(x => x.Id == item.Id))!;
            elementU.Descripcion = item.Descripcion;
            _context.Meses.Update(elementU);
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
            return elementU;
        }
        public async Task<bool> Delete(Meses item)
        {
            Meses elementU = (await _context.Meses.FirstOrDefaultAsync(x => x.Id == item.Id))!;
            _context.Meses.Remove(elementU);
            await _context.SaveChangesAsync();
            await _context.DisposeAsync();
            return await Task.FromResult(true);
        }
    }
}
