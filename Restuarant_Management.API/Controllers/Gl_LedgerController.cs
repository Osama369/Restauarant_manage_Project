using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restauarant_Management.Models.Models;
using Restuarant_Management.Services.IServices;

namespace Restuarant_Management.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Gl_LedgerController : ControllerBase
    {
        private readonly IGl_LedgerService _ledgerService;

        public Gl_LedgerController(IGl_LedgerService ledgerService)
        {
            _ledgerService = ledgerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ledgerService.GetAllLedgerAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _ledgerService.GetLedgerByIdAsync(id);
            return result != null ? Ok(result) : NotFound("Not found");
        }

        [HttpPost]
        public async Task<IActionResult> Add(Gl_Ledger glLedger)
        {
             await _ledgerService.AddLedgerAsync(glLedger);
            return Ok(new { message = "legder created successfully" });

        }

        [HttpPut]
        public async Task<IActionResult> Update(Gl_Ledger glLedger)
        {
            var result = await _ledgerService.UpdateLedgerAsync(glLedger);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ledgerService.DeleteLedgerAsync(id);
            return Ok("Deleted successfully");
        }
    
}
}
