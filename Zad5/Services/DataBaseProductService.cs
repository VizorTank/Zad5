using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad5.Data;
using Zad5.Models;

namespace Zad5.Services
{
    public class DataBaseProductService
    {
        private readonly DbProductContext _context;
        public DataBaseProductService(DbProductContext context)
        {
            _context = context;
        }

        public IEnumerable<DbProduct> GetProducts()
        {
            var DbProductQuerry = from DbProduct in _context.DbProduct select DbProduct;
            return DbProductQuerry.ToList();
        }
    }
}
