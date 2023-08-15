using API.Contracts;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _db;

        public BookRepository (ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Book> CreateAsync(Book book)
        {
            book.Guid = Guid.NewGuid().ToString();
            await _db.Books.AddAsync(book);
            return await _db.SaveChangesAsync() > 0 ? book : null;
        }

        public IQueryable<Book> GetAll() => _db.Books.AsNoTracking();

        public IQueryable<Book> GetByAuthor(int authorId)
            => _db.Books.Where(x => x.AuthorId == authorId).AsNoTracking();

        public IQueryable<Book> GetByTitle(string title, StringComparison comparison, bool isEqual)
        {
            if (string.IsNullOrEmpty(title)) 
            {
                return Enumerable.Empty<Book>().AsQueryable();
            }                
            
            if (isEqual)
            {
                return _db.Books.Where(x => x.Title.Equals(title, comparison));
            }

            return _db.Books.Where(x => x.Title.Contains(title, comparison));
        }
    }
}