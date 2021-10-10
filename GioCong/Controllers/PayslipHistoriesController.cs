using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/payslip-histories")]
    public partial class PayslipHistoriesController : ControllerBase
    {
        private readonly IPayslipHistoryService _payslipHistoryService;
        public PayslipHistoriesController(IPayslipHistoryService payslipHistoryService){
            _payslipHistoryService=payslipHistoryService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_payslipHistoryService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_payslipHistoryService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(PayslipHistory entity)
        {
            _payslipHistoryService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,PayslipHistory entity)
        {
            _payslipHistoryService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,PayslipHistory entity)
        {
            _payslipHistoryService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_payslipHistoryService.Count());
        }
    }
}
