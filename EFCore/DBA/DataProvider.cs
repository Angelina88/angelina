using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCore.DBA
{
    internal class DataProvider : IDataProvider
    {
        private DbContext _context;

        public DataProvider(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Select<T>(IEnumerable<string> includes) 
            where T : Entity
        {
            var set =_context.Set<T>();
            IQueryable<T> query = set;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query.AsEnumerable<T>();
        }


        public void Create<T>(T entity) where T : Entity
        {
            _context.Add(entity);
            _context.SaveChanges();
        }
    }
}
