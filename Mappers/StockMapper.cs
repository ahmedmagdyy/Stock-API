using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.DTOs.Stocks;
using Todo.Models;

namespace Todo.Mappers
{
    public static class StockMapper
    {
        public static StockDTO MapToDTO(this Stock stockModel)
        {
            return new StockDTO
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap
            };
        }
    };
};