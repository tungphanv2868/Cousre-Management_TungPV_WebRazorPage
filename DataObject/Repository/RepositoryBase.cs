using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class RepositoryBase<T> where T : class
    {
        private readonly CousreManagementContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositoryBase(CousreManagementContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();

        }
        public void Delete(T item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
        public void Update(T item)
        {
            _dbSet.Update(item);
            _context.SaveChanges();
        }
        public T getById(object id)
        {
            return _dbSet.Find(id);
        }
    }
}
