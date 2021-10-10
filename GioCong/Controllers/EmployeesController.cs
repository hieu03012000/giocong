using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public partial class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService){
            _employeeService=employeeService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_employeeService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_employeeService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(Employee entity)
        {
            _employeeService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,Employee entity)
        {
            _employeeService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,Employee entity)
        {
            _employeeService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_employeeService.Count());
        }
    }
}
