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
        private readonly ILogger<TonghopbienapController> _logger;

        public TonghopbienapController(ITonghopbienapService service, ILogger<TonghopbienapController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpPost("Add")]
        public async Task<ActionResult> Add([FromBody] TonghopBienap request)
        {
            _logger.LogInformation($"Add received: BienapId={request?.BienapId}, PhongbanId={request?.PhongbanId}, NgayLap={request?.NgayLap}");

            if (request == null)
            {
                return BadRequest("Request không được rỗng");
            }
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                var errorList = errors.Select(e => e.ErrorMessage).ToList();
                _logger.LogError($"ModelState errors: {string.Join(", ", errorList)}");
                return BadRequest(new { message = "Model validation failed", errors = errorList });
            }
            var result = await _service.Add(request);
            if (result == null)
            {
                return BadRequest("Thêm mới thất bại");
            }
            return Ok(result);
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
            if (result == null)
            {
                return BadRequest("Cập nhật thất bại");
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var query = await _service.GetAll();
            return Ok(query);

        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var deleted = await _service.Delete(id);
            if (!deleted)
            {
                return NotFound("Không tìm thấy bản ghi");
            }
            return Ok();
        }
        [HttpPost("DeleteSelect")]
        public async Task<IActionResult> DeleteSelect([FromBody] List<int> ids)
        {
            var query = await _service.DeleteSelect(ids);
            if (query == null || query.Count == null || query.Count.Equals(0))
            {
                return NotFound("Không xóa được bản ghi nào");
            }
            return Ok(query.Count);

        }
    }
}
