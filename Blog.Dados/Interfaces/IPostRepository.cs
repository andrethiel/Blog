using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Dados.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> GetList();
        Task<Post> Get(string id);
        Task Create(Post post);
        Task Update(Post post);
        Task Delete(int id);
    }
}
