using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodeFormatter13.Controllers.CodeFormatter
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class CodeFormatterController: ControllerBase
    {

        public CodeFormatterController()
        {

        }

        [HttpPost()]
        [Route("formatarLista")]
        public IActionResult FormatarLista([FromBody] string lista)
        {
            var ok = new List<string>();

            return Ok(ok);
        }
    }
}
