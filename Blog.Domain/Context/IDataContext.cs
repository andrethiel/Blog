using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Context
{
    public interface IDataContext<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> AsQueryable();
        Task<TDocument> FilterBy(Expression<Func<TDocument, bool>> filterExpression);

        Task InsertOneAsync(TDocument document);
        Task ReplaceOneAsync(TDocument document);
        //Task<List<T>> ExecuteList<T>(T model);

        //Task ExecuteSave<T>(T model);
        //Task ExecuteUpdate<T>(T model, string id);
    }
}
