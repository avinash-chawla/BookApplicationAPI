using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApplicationAPI.Business.Interfaces;
using BookApplicationAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApplicationAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookBL bookBL;

        public BooksController(IBookBL bookBL)
        {
            this.bookBL = bookBL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.bookBL.GetBooks());
        }
    }
}
