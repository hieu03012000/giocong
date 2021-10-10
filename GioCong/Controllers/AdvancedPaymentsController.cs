using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/advanced-payments")]
    public partial class AdvancedPaymentsController : ControllerBase
    {
        private readonly IAdvancedPaymentService _advancedPaymentService;
        public AdvancedPaymentsController(IAdvancedPaymentService advancedPaymentService){
            _advancedPaymentService=advancedPaymentService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_advancedPaymentService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_advancedPaymentService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(AdvancedPayment entity)
        {
            _advancedPaymentService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,AdvancedPayment entity)
        {
            _advancedPaymentService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,AdvancedPayment entity)
        {
            _advancedPaymentService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_advancedPaymentService.Count());
        }
    }
}
