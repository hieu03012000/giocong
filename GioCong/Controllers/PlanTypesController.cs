using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/plan-types")]
    public partial class PlanTypesController : ControllerBase
    {
        private readonly IPlanTypeService _planTypeService;
        public PlanTypesController(IPlanTypeService planTypeService){
            _planTypeService=planTypeService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_planTypeService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_planTypeService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(PlanType entity)
        {
            _planTypeService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,PlanType entity)
        {
            _planTypeService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,PlanType entity)
        {
            _planTypeService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_planTypeService.Count());
        }
    }
}
