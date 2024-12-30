using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Domain.Context;

namespace Blog.Domain.Models
{
    [BsonCollection("Post")]
    public class Post : Document
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Usuario { get; set; }
        public DateTime DataPost { get; set; }
    }
}
