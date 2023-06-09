﻿using backend.backend_BLL.Interfaces;
using backend.backend_BLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerService _partnerService;
        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpPost("CreatePartner")]
        public async Task<IActionResult> Post([FromBody] PartnerModel partner)
        {
            await _partnerService.Create(partner);
            return Ok(partner);
        }

        [HttpGet("GetAllPartners")]
        public async Task<List<PartnerModel>> GetAllPartners()
        {
            var list = await _partnerService.GetPartners();
            return list;
        }

        [HttpPut("AddPartnerRepresentant/{id}")]
        public async Task<IActionResult> AddPartnerRepresentant([FromRoute] string id, [FromBody] RegisterModel registerModel)
        {
            try
            {

                Console.WriteLine(registerModel);
                await _partnerService.RegisterPartner(id, registerModel);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
