using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Entites;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TonghopbienapController : ControllerBase
    {
        public readonly ITonghopbienapService _service;
        public TonghopbienapController(ITonghopbienapService service)
        {
            _service = service;
        }
        [HttpPost("Add")]
        public async Task<ActionResult> Add([FromBody] TonghopBienap request)
        {
            if (request == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _service.Add(request);
            if (!result)
            {
                return BadRequest("Thêm mới thất bại");
            }
            return Ok();
        }
        [HttpGet("DetailById/{Id}")]
        public async Task<ActionResult> GetDetailById(int Id)
        {
            var entity = await _service.getDatailById(Id);
            return Ok(entity);
        }

        [HttpPut("Update")]
        public async Task<ActionResult> Update([FromBody] TonghopBienap request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _service.Update(request);
            if (!result)
            {
                return BadRequest("Cập nhật thất bại");
            }
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            await _service.Delete(id);
            return Ok();
        }
        [HttpPost("DeleteSelect")]
        public async Task<IActionResult> DeleteSelect([FromBody] List<int> ids)
        {
            var query = await _service.DeleteSelect(ids);
            if (query.Count == 0)
            {
                return NotFound("Không xóa được bản ghi nào");
            }
            return Ok(query.Count);

        }
    }
}
