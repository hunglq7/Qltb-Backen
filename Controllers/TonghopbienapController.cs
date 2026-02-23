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
            try
            {
                _logger.LogInformation($"Add received: BienapId={request?.BienapId}, PhongbanId={request?.PhongbanId}, NgayLap={request?.NgayLap}");

                if (request == null)
                {
                    return BadRequest(new { message = "Request không được rỗng", success = false });
                }
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors);
                    var errorList = errors.Select(e => e.ErrorMessage).ToList();
                    _logger.LogError($"ModelState errors: {string.Join(", ", errorList)}");
                    return BadRequest(new { message = "Model validation failed", errors = errorList, success = false });
                }
                var result = await _service.Add(request);
                _logger.LogInformation($"Add created record with ID: {result.Id}");
                return Ok(new { data = result, success = true });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Add error: {ex.Message}");
                return BadRequest(new { message = ex.Message, success = false });
            }
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
            try
            {
                if (request == null)
                    return BadRequest(new { message = "Request không hợp lệ", success = false });

                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors)
                                                  .Select(e => e.ErrorMessage)
                                                  .ToList();
                    return BadRequest(new { message = "Model validation failed", errors, success = false });
                }

                var result = await _service.Update(request);
                return Ok(new { data = result, success = true });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Update error: {ex}");
                return StatusCode(500, new { message = ex.Message, success = false });
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                _logger.LogInformation("GetAll called");
                var query = await _service.GetAll();
                _logger.LogInformation($"GetAll returned {query?.Count ?? 0} records");
                return Ok(new { data = query, success = true });
            }
            catch (Exception ex)
            {
                _logger.LogError($"GetAll error: {ex.Message}\n{ex.StackTrace}");
                return StatusCode(500, new { message = $"GetAll error: {ex.Message}", success = false });
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                _logger.LogInformation($"Delete called with ID: {id}");

                if (id == 0)
                {
                    return BadRequest(new { message = "ID không hợp lệ", success = false });
                }
                var deleted = await _service.Delete(id);
                if (!deleted)
                {
                    return NotFound(new { message = "Không tìm thấy bản ghi", success = false });
                }
                _logger.LogInformation($"Delete successful for ID: {id}");
                return Ok(new { message = "Xóa thành công", success = true });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Delete error: {ex.Message}");
                return BadRequest(new { message = ex.Message, success = false });
            }
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
