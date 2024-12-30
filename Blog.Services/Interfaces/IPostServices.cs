using Blog.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Interfaces
{
    public interface IPostServices
    {
        Task<List<PostViewModel>> GetList();
        Task<PostViewModel> Get(string id);
        Task Create(PostViewModel post);
        Task Update(PostViewModel post);
        Task Delete(int id);
    }
}
