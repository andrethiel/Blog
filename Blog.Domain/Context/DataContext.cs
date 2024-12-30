using Blog.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Context
{
    public class DataContext<TDocument> : IDataContext<TDocument> where TDocument : IDocument
    {
        private readonly IMongoCollection<TDocument> _collection;
        public DataContext(IOptions<ConnectionString> _connectionString)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://andrethiel007:Aj95vwIn0Hd759gs@cluster0.14cuj.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var client = new MongoClient(settings).GetDatabase("Blog");
            _collection = client.GetCollection<TDocument>(typeof(TDocument).Name);
        }

        public async Task<IEnumerable<TDocument>> AsQueryable()
        {
            return await _collection.Find(Builders<TDocument>.Filter.Empty).ToListAsync();
        }

        public async Task<TDocument> FilterBy(Expression<Func<TDocument, bool>> filterExpression)
        {
            return await _collection.Find(filterExpression).FirstOrDefaultAsync();
        }

        public async Task InsertOneAsync(TDocument document)
        {
            await _collection.InsertOneAsync(document);
        }

        public async Task ReplaceOneAsync(TDocument document)
        {
            await _collection.FindOneAndReplaceAsync(Builders<TDocument>.Filter.Eq(x => x.Id, document.Id), document);
        }
    }
}
