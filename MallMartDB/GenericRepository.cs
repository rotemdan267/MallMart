using MallMartDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMartDB
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        private MallMartContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new MallMartContext();
            table = _context.Set<T>();
        }
        public GenericRepository(MallMartContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            _context.Entry(obj).State = EntityState.Added;
        }
        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
