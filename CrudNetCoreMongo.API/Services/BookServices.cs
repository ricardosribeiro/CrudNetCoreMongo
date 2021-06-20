using System.Collections.Generic;
using CrudNetCoreMongo.API.Models;
using CrudNetCoreMongo.Domain.Entities;
using MongoDB.Driver;

namespace CrudNetCoreMongo.API.Services
{
    public class BookServices
    {
        private readonly IMongoCollection<Book> _books;

        public BookServices(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Book>(settings.BooksColletionName);
        }

        public List<Book> GetList() =>
            _books.Find(book => true).ToList();

        public Book GetBook(string id) =>
            _books.Find<Book>(book => book.Id.Equals(id)).FirstOrDefault();

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id, Book book) =>
            _books.ReplaceOne(book => book.Id.Equals(id), book);

        public void Remove(Book book) =>
            _books.DeleteOne(book => book.Id.Equals(book.Id));

        public void Remove(string id) =>
            _books.DeleteOne(book => book.Id.Equals(id));
    }
}