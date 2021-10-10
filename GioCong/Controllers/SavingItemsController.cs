using GioCong.Data.Models;
using GioCong.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace GioCong.Controllers
{
    [ApiController]
    [Route("api/saving-items")]
    public partial class SavingItemsController : ControllerBase
    {
        private readonly ISavingItemService _savingItemService;
        public SavingItemsController(ISavingItemService savingItemService){
            _savingItemService=savingItemService;
        }
        [HttpGet]
        public IActionResult Gets()
        {
            return Ok(_savingItemService.Get().ToList());
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(Guid id)
        {
            return Ok(_savingItemService.Get(id));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(SavingItem entity)
        {
            _savingItemService.Create(entity);
            return  CreatedAtAction(nameof(GetById), new { id = entity}, entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Update(Guid id,SavingItem entity)
        {
            _savingItemService.UpdateAsync(entity);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,SavingItem entity)
        {
            _savingItemService.DeleteAsync(entity);
            return Ok();
        }
        [HttpGet("count")]
        public IActionResult Count()
        {
            return Ok(_savingItemService.Count());
        }
    }
}
