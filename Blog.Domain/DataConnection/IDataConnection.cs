using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.DataConnection
{
    public interface IDataConnection
    {
        string DefaultConnection { get; set; }
    }
}
