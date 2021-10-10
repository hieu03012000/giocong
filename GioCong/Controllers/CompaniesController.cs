using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public partial class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService){
            _companyService=companyService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_companyService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_companyService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(Company entity)
        {
            _companyService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,Company entity)
        {
            _companyService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,Company entity)
        {
            _companyService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_companyService.Count());
        }
    }
}
