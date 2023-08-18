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

        [UseFirstOrDefault]
        public IQueryable<Author> GetAuthor([Service] IAuthorRepository repo, string id)
            => repo.GetById(id);
    }
}