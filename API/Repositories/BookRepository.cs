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

        public async Task<IEnumerable<Book>> GetAllAsync()
            => await _db.Books.AsNoTracking().ToListAsync();

        public async Task<IEnumerable<Book>> GetByAuthorAsync(int authorId)
            => await _db.Books.Where(x => x.AuthorId == authorId).AsNoTracking().ToListAsync();

        public async Task<IEnumerable<Book>> GetByTitleAsync(string title, StringComparison comparison, bool isEqual)
        {
            if (string.IsNullOrEmpty(title)) 
            {
                return Enumerable.Empty<Book>();
            }                
            
            if (isEqual)
            {
                return await _db.Books.Where(x => x.Title.Equals(title, comparison)).ToListAsync();
            }

            return await _db.Books.Where(x => x.Title.Contains(title, comparison)).ToListAsync();
        }
    }
}