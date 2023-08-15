using API.Contracts;
using API.Entities;

namespace API.GraphQL.QueryTypes
{
    [ExtendObjectType("Query")]
    public class AuthorQuery
    {
        [UseProjection]
        public IQueryable<Author> GetAuthors([Service] IAuthorRepository repo)
            => repo.GetAll();

        [UseProjection]
        public IQueryable<Author> GetAuthorsWithBooks([Service] IAuthorRepository repo)
            => repo.GetAllWithBooks();

        [UseFirstOrDefault]
        public IQueryable<Author> GetAuthor([Service] IAuthorRepository repo, string id)
            => repo.GetById(id);
    }
}