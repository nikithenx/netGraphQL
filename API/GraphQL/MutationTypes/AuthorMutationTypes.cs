using API.Contracts;
using API.DTOs.Authors;
using API.Entities;

namespace API.MutationTypes
{
    public class AuthorMutationTypes
    {
        public async Task<Author> CreateAuthor([Service] IAuthorRepository repo, AuthorCreateDto createDto)
        {
            Author author = new()
            {
                FirstName = createDto.FirstName,
                LastName = createDto.LastName,
                Gender = createDto.Gender,
                Age = createDto.Age
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
                Age = updateDto.Age
            };
            return await repo.UpdateAsync(author);
        }
            
        public async Task<bool> DeleteAuthor([Service] IAuthorRepository repo, int id)
            => await repo.DeleteAsync(id);
        
    }
}