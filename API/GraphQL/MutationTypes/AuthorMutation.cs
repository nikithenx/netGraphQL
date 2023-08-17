using API.Contracts;
using API.DTOs.Authors;
using API.Entities;

namespace API.GraphQL.MutationTypes
{
    [ExtendObjectType("Mutation")]
    public class AuthorMutation
    {
        public async Task<Author> CreateAuthor([Service] IAuthorRepository repo, AuthorCreateDto createDto)
        {
            Author author = new()
            {
                FirstName = createDto.FirstName,
                LastName = createDto.LastName,
                Gender = createDto.Gender,
                Age = createDto.Age,
                Bio = createDto.Bio,
            };
            return await repo.CreateAsync(author);
        }
            
        public async Task<bool> UpdateAuthor([Service] IAuthorRepository repo, AuthorUpdateDto updateDto)
        {
            Author author = new()
            {
                Id = updateDto.Id,
                Guid = updateDto.Guid,
                FirstName = updateDto.FirstName,
                LastName = updateDto.LastName,
                Gender = updateDto.Gender,
                Age = updateDto.Age,
                Bio = updateDto.Bio,
            };
            return await repo.UpdateAsync(author);
        }
            
        public async Task<bool> DeleteAuthor([Service] IAuthorRepository repo, int id)
            => await repo.DeleteAsync(id);
        
    }
}