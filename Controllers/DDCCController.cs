using DDCC.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDCC.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DDCCController : ControllerBase
    {
        private readonly IDDCC _iController;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public DDCCController(IDDCC iController, IWebHostEnvironment hostingEnvironment)
        {
            _iController = iController;
            _hostingEnvironment = hostingEnvironment;
        }
        
        [HttpGet("monthly-data")]
        public async Task<IActionResult> GetMonthlyData()
        {
            try
            {
                var result = await _iController.GetMonthlyData();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
