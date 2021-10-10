using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/pay-advanceds")]
    public partial class PayAdvancedsController : ControllerBase
    {
        private readonly IPayAdvancedService _payAdvancedService;
        public PayAdvancedsController(IPayAdvancedService payAdvancedService){
            _payAdvancedService=payAdvancedService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_payAdvancedService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_payAdvancedService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(PayAdvanced entity)
        {
            _payAdvancedService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,PayAdvanced entity)
        {
            _payAdvancedService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,PayAdvanced entity)
        {
            _payAdvancedService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_payAdvancedService.Count());
        }
    }
}
