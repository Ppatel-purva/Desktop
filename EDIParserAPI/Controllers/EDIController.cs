using Microsoft.AspNetCore.Mvc;
using EDIParserAPIService.Models;
using EDIParserAPIService.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDIParserAPIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EDIController : ControllerBase
    {
        private readonly ICosmosDbService _cosmosDbService;

        public EDIController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService ?? throw new ArgumentNullException(nameof(cosmosDbService));
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _cosmosDbService.GetMultipleAsync("SELECT * FROM c"));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            return Ok(await _cosmosDbService.GetAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] EDI edi)
        {
            edi.id = Guid.NewGuid().ToString();
            await _cosmosDbService.AddAsync(edi);
            return CreatedAtAction(nameof(Get), new { id = edi.id }, edi);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(EDI edi)
        {
            await _cosmosDbService.UpdateAsync(edi.id, edi);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _cosmosDbService.DeleteAsync(id);
            return Ok();
        }
    }
}