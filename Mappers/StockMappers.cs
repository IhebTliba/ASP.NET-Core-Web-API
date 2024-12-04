using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using my_api.Dtos;
using my_api.Models;

namespace my_api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id=stockModel.Id,
                Symbol=stockModel.Symbol,
                CompanyName=stockModel.CompanyName,
                Purshase=stockModel.Purshase,
                LastDiv=stockModel.LastDiv,
                Industry=stockModel.Industry,
                MarketCap=stockModel.MarketCap

            };
        }
    }
}