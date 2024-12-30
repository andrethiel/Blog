using Blog.Dados.Interfaces;
using Blog.Domain.Context;
using Blog.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dados.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly IDataContext<Post> _context;

        public PostRepository(IDataContext<Post> context)
        {
            _context = context;
        }

        public Task Create(Post post) => _context.InsertOneAsync(post);

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> Get(string id) => await _context.FilterBy(x => x.Id.ToString() == id);

        public async Task<List<Post>> GetList()
        {
            var lista = await _context.AsQueryable();

            return lista.ToList();
        }

        public Task Update(Post post) => _context.ReplaceOneAsync(post);
    }
}
