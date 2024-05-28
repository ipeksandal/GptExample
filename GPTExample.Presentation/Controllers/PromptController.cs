using GPTExample.Aplication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromptsController : ControllerBase
    {
        private readonly IPromptService _promptService;

        public PromptsController(IPromptService promptService)
        {
            _promptService = promptService;
        }

        [HttpGet]
        public IActionResult GetPrompts(string userId)
        {
            var prompts = _promptService.GetPrompts(userId);

            return Ok(prompts);
        }
        
    }
}