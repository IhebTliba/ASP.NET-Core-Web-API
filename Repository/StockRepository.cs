using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using my_api.Data;
using my_api.Interfaces;
using my_api.Models;

namespace my_api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context )
        {
            _context=context;
            
        }
        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stock.ToListAsync();
            
        }
    }
}