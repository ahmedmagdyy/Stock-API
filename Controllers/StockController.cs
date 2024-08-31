using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Todo.data;
using Todo.Mappers;
using Todo.Models;

namespace Todo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Stock>> GetAll()
        {
            var stocks = _context.Stocks.ToList().Select(s => s.MapToDTO());
            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public ActionResult<Stock> Get([FromRoute] int id)
        {
            var stock = _context.Stocks.Find(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock.MapToDTO());
        }
    }
}