using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/pay-schedules")]
    public partial class PaySchedulesController : ControllerBase
    {
        private readonly IPayScheduleService _payScheduleService;
        public PaySchedulesController(IPayScheduleService payScheduleService){
            _payScheduleService=payScheduleService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_payScheduleService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_payScheduleService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(PaySchedule entity)
        {
            _payScheduleService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,PaySchedule entity)
        {
            _payScheduleService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,PaySchedule entity)
        {
            _payScheduleService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_payScheduleService.Count());
        }
    }
}
