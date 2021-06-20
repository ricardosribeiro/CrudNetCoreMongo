using Microsoft.AspNetCore.Mvc;
using CrudNetCoreMongo.API.Services;
using System.Collections.Generic;
using CrudNetCoreMongo.Domain.Entities;

namespace CrudNetCoreMongo.API.Controllers
{

    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BookServices _service;

        public BooksController(BookServices service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetList() =>
            _service.GetList();

        [HttpPost]
        public ActionResult Create(Book book)
        {
            _service.Create(book);
            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }
    }
}