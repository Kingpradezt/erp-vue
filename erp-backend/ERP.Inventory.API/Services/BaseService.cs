using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ERP.Inventory.API.Data; // Ensure this matches your AppDbContext namespace

namespace ERP.Inventory.API.Services
{
    public class BaseService
    {
        private readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> ListOfTable<T>(
            Expression<Func<T, bool>>? where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            int? skip = null,
            int? take = null
        ) where T : class
        {
            IQueryable<T> query = _context.Set<T>();

            if (where != null)
                query = query.Where(where);

            if (orderBy != null)
                query = orderBy(query);

            if (skip.HasValue)
                query = query.Skip(skip.Value);

            if (take.HasValue)
                query = query.Take(take.Value);

            return await query.ToListAsync();
        }

        public async Task<List<T>> RawSqlQuery<T>(string sql, params object[] parameters) where T : class
        {
            return await _context.Set<T>().FromSqlRaw(sql, parameters).ToListAsync();
        }
    }
}
