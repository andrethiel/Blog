using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.DataConnection
{
    public class DataConnection : IDataConnection
    {
        public string DefaultConnection { get; set; }
    }
}
