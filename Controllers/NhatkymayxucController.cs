using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data.Entites;
using WebApi.Models.ThongsokythuatMayXuc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhatkymayxucController : ControllerBase
    {
        public readonly INhatkymayxucService _nhatkymayxucService;
        public NhatkymayxucController(INhatkymayxucService nhatkymayxucService)
        {
            _nhatkymayxucService = nhatkymayxucService;

        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var query = await _nhatkymayxucService.GetAll();
            return Ok(query);
        }
        [HttpGet("DatailById/{Id}")]
        public async Task<ActionResult> GetDetailById(int Id)
        {
            var items = await _nhatkymayxucService.getDatailById(Id);
            return Ok(items);
        }

        [HttpPut("UpdateMultiple")]
        public async Task<ActionResult> UpdateMuliple([FromBody] List<NhatkyMayxuc> request)
        {
            var query = await _nhatkymayxucService.UpdateMultiple(request);
            if (query.Count == 0)
            {
                return BadRequest("Cập nhật bản ghi thất bại");
            }
            return Ok(query.Count);

        }

        [HttpPost("DeleteMultipale")]

        public async Task<ActionResult> DeleteMultiple([FromBody] List<NhatkyMayxuc> request)
        {
            var query = await _nhatkymayxucService.DeleteMutiple(request);
            if (query.Count == 0)
            {
                return BadRequest("Xóa bản ghi thất bại");
            }
            return Ok(query.Count);
        }
        [HttpPost("Add")]
        public async Task<ActionResult> Add([FromBody] NhatkyMayxuc request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            await _nhatkymayxucService.Add(request);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<ActionResult> Update([FromBody] NhatkyMayxuc request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _nhatkymayxucService.Update(request);
            return Ok();
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            await _nhatkymayxucService.Delete(id);
            return Ok();
        }
        [HttpPost("DeleteMultiplet")]
        public async Task<IActionResult> DeleteMultiple([FromBody] List<int> ids)
        {
            var result = await _nhatkymayxucService.DeleteMutiplet(ids);
            return Ok(result);
        }
    }
}
