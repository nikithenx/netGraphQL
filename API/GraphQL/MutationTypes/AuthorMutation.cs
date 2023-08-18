using API.Contracts;
using API.DTOs.Authors;
using API.Entities;
using AutoMapper;

namespace API.GraphQL.MutationTypes
{
    [ExtendObjectType("Mutation")]
    public class AuthorMutation
    {
        public async Task<Author> CreateAuthor(
            [Service] IAuthorRepository repo, 
            [Service] IMapper mapper,
            AuthorCreateDto createDto)
        {
            Author author = mapper.Map<Author>(createDto);
            return await repo.CreateAsync(author);
        }
            
        public async Task<bool> UpdateAuthor(
            [Service] IAuthorRepository repo, 
            [Service] IMapper mapper,
            AuthorUpdateDto updateDto)
        {
            Author author = mapper.Map<Author>(updateDto);
            return await repo.UpdateAsync(author);
        }
            
        public async Task<bool> DeleteAuthor([Service] IAuthorRepository repo, int id)
            => await repo.DeleteAsync(id);
        
    }
}