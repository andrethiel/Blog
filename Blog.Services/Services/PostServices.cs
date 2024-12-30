using Blog.Dados.Interfaces;
using Blog.Domain.Models;
using Blog.Services.Interfaces;
using Blog.Services.ViewModels;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services
{
    public class PostServices : IPostServices
    {
        private readonly IPostRepository _postRepository;
        public PostServices(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task Create(PostViewModel post)
        {
            var modelo = new Post
            {
                Titulo = post.Titulo,
                Texto = post.Texto,
                Usuario = post.Usuario,
                DataPost = DateTime.Now
            };
            await _postRepository.Create(modelo);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<PostViewModel> Get(string id)
        {
            var post = await _postRepository.Get(id);
            return new PostViewModel()
            {
                Id = post.Id.ToString(),
                DataPost = post.DataPost.ToString("dd/MM/yyyy"),
                Texto = post.Texto,
                Titulo = post.Titulo,
                Usuario = post.Usuario
            };
        }

        public async Task<List<PostViewModel>> GetList()
        {
            var lista = await _postRepository.GetList();
            return lista.Select(x => new PostViewModel
            {
                Id = x.Id.ToString(),
                Titulo = x.Titulo,
                Texto = x.Texto,
                Usuario = x.Usuario,
                DataPost = x.DataPost.ToString("dd/MM/yyyy")
            }).ToList();
        }

        public async Task Update(PostViewModel post)
        {
            var modelo = new Post
            {
                Id = new ObjectId(post.Id),
                Titulo = post.Titulo,
                Texto = post.Texto,
                Usuario = post.Usuario,
                DataPost = DateTime.Now
            };

            await _postRepository.Update(modelo);
        }
    }
}
