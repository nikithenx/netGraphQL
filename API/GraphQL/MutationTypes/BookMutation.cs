using API.Contracts;
using API.DTOs.Books;
using API.Entities;
using AutoMapper;

namespace API.GraphQL.MutationTypes
{
    [ExtendObjectType("Mutation")]
    public class BookMutation
    {
        public async Task<Book> CreateBook(
            [Service] IBookRepository repo, 
            [Service] IMapper mapper,
            BookCreateDto createDto)
        {
            Book book = mapper.Map<Book>(createDto);
            return await repo.CreateAsync(book);
        }       
    }
}