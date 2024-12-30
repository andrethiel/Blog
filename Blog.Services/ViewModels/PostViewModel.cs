using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.ViewModels
{
    public class PostViewModel
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Usuario { get; set; }
        public string DataPost { get; set; }
    }
}
