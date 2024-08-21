using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using Todo.Application.DTOs;
using Todo.Application.Helpers;
using Todo.Application.Interface.IServices;

namespace Todo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        public readonly IListService _listService;

        public ListController(IListService listService)
        {
            _listService = listService;
        }

        //[Authorize]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var currentUserId = User.FindFirstValue("userId");

            if(currentUserId == null)
            {
                return NotFound(new { message = "User Not Logged In"});
            }

            var lists = await _listService.GetAll(currentUserId);

            if(lists == null)
            {
                return NotFound(new { message = "No List Found For This User." });
            }
            return Ok(new Response(lists, null, HttpStatusCode.OK));
        }

        [HttpPost("AddList")]
        public async Task<IActionResult> AddList([FromBody] AddListDTO addListDto)
        {
            var errors = new List<string>();
            var currentUserId = User.FindFirstValue("userId") ?? "NoUserId";

            var result = await _listService.AddList(addListDto, errors, currentUserId);

            if (errors.Count > 0)
            {
                return BadRequest(new Response(null, errors, HttpStatusCode.BadRequest));
            }

            return Ok(new { message = result });
        }

        [HttpPut]
        public async Task<IActionResult> UpdateList([FromBody] UpdateListDTO updateListDto)
        {
            return null;
        }
    }
}