using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Dtos
{
    public class StockDto
    {
        public int Id {get; set;}
        public string Symbol {get; set;} = string.Empty;
        public string CompanyName {get; set;} = string.Empty;
        public decimal Purshase {get; set;}
        public decimal LastDiv {get; set;}
        public string Industry  {get; set;}=string.Empty;
        public long MarketCap {get; set;}
        
    }
}