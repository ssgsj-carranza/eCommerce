using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using eCommerceStarterCode.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        public ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet, Authorize]
        public IActionResult Get()

        {
            var shoppingcarts = _context.ShoppingCarts;
	        return Ok(shoppingcarts);
        }
        [HttpPost, Authorize]
        public IActionResult Post([FromBody]ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            var ShoppingCartItem = _context.ShoppingCarts.Include(p => p.Product).Include(p => p.User).Where(sc => sc.Id == value.Id).FirstOrDefault();
            return StatusCode(201, ShoppingCartItem);
        }
        [HttpDelete] //Probably wrong address. Needs to be unique for each product? DEFINITELY WRONG
        public IActionResult Delete([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Remove(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
