using AutoMapper;
using Drugovich.API.Utils.Exception;
using Drugovich.Domain.Dtos;
using Drugovich.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Drugovich.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }
        [Authorize(Roles = "niveldois")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                return Ok(new ApiResponseOk(await _service.GetAll()));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse((int)HttpStatusCode.InternalServerError));
            }
        }

        [Authorize(Roles = "niveldois")]
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                return Ok(new ApiResponseOk(await _service.Get(id)));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse((int)HttpStatusCode.InternalServerError));
            }
        }
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClienteDto cliente)
        {
            if (!ModelState.IsValid) return BadRequest(new ApiResponseBadRequest(ModelState));
            try
            {
                if (cliente == null) return BadRequest();
                var result = await _service.Create(cliente);

                return Ok(new ApiResponseOk(result));

            }
            catch (Exception e)
            {
                return  StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse((int)HttpStatusCode.InternalServerError));
            }

        }
        [Authorize(Roles = "niveldois")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ClienteDto cliente)
        {
            if (!ModelState.IsValid) return BadRequest(new ApiResponseBadRequest(ModelState));
            try
            {
                if (cliente == null) return BadRequest();
                var result = await _service.Update(cliente);

                return Ok(new ApiResponseOk(result));
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse((int)HttpStatusCode.InternalServerError));
            }
        }
        [Authorize]
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(new ApiResponseBadRequest(ModelState));

            try
            {
                return Ok(new ApiResponseOk(await _service.Delete(id)));
            }
            catch (Exception e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, new ApiResponse((int)HttpStatusCode.InternalServerError));
            }
        }
    }
}
