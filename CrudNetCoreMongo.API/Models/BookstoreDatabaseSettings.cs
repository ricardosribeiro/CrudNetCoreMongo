namespace CrudNetCoreMongo.API.Models
{
    /* Classe usada para armazenar os valores do arquivo appSettings.json */
    public class BookstoreDatabaseSettings:IBookstoreDatabaseSettings
    {
        public string BooksColletionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IBookstoreDatabaseSettings
    {
        string BooksColletionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}