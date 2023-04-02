using backend.backend_BLL.Interfaces;
using backend.backend_BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        private readonly ICodeService _codeService;

        public CodeController(ICodeService codeService)
        {
            _codeService = codeService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CodeModel code)
        {
            await _codeService.Create(code);
            return Ok(code);
        }

        [HttpGet("GetAllCodes")]
        public async Task<List<string>> GetAllCodes()
        {
            var list = await _codeService.GetCodes();
            return list;
        }
    }
}
