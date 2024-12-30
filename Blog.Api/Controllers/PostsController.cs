using Blog.Services.Interfaces;
using Blog.Services.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostServices _postServices;
        public PostsController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        [HttpGet]
        [Route("Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var posts = await _postServices.GetList();
                return Ok(posts);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar posts. Erro: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("ListarPorId")]
        public async Task<IActionResult> ListarPorId(string id)
        {
            try
            {
                var posts = await _postServices.Get(id);
                return Ok(posts);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar posts. Erro: {ex.Message}");
            }
        }

        [HttpPost]
        [Route("Inserir")]
        public async Task<IActionResult> Inserir(PostViewModel post)
        {
            try
            {
                await _postServices.Create(post);
                return Created();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar criar post. Erro: {ex.Message}");
            }
        }

        [HttpPut]
        [Route("Alterar")]
        public async Task<IActionResult> Alterar(PostViewModel post)
        {
            try
            {
                await _postServices.Update(post);
                return Created();
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar criar post. Erro: {ex.Message}");
            }
        }
    }
}
