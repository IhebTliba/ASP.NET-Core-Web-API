using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_api.Models;

namespace my_api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();
         
    }
}