using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Dto;
using Repository.Entities;
using Repository.rep;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public ProductsController(IRepository repository , IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{name}")]
        public ActionResult<List<Product>> Get(string name)
        {
            return Ok(_repository.Search(name));
        }

        
    }
}
