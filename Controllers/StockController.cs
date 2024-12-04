using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_api.Data;
using my_api.Interfaces;
using my_api.Mappers;

namespace my_api.Controllers
{
    [Route("api/Stock")]
    [ApiController]
    public class StockController: ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IStockRepository _stockRepo;
        public StockController(ApplicationDBContext  context, IStockRepository stockRepo)
        {
          _context= context;   
          _stockRepo=stockRepo;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var stocks= await _stockRepo.GetAllAsync();
            var stockDto=stocks.Select(s=>s.ToStockDto());
            return Ok(stockDto);

        }
        
    }
}