using API.Contracts;
using API.DTOs.Books;
using API.Entities;

namespace API.GraphQL.MutationTypes
{
    [ExtendObjectType("Mutation")]
    public class BookMutation
    {
        public async Task<Book> CreateBook([Service] IBookRepository repo, BookCreateDto createDto)
        {
            Book book = new()
            {
                AuthorId = createDto.AuthorId,
                Title = createDto.Title,
                ISBN = createDto.ISBN,
            };
            return await repo.CreateAsync(book);
        }
          
    }
}