using Microsoft.AspNetCore.Mvc;

namespace append_file_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly OutputFile _outputFile;

        public FilesController(OutputFile outputFile)
        {
            _outputFile = outputFile;
        }

        [HttpPost("{fileName}/lines")]
        public void AppendLine([FromRoute] string fileName, [FromForm] string line)
        {
            lock (_outputFile)
            {
                _outputFile.AppendLine(fileName, line);
            }
        }
    }
}
