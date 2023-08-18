using API.DTOs.Authors;
using API.DTOs.Books;
using API.Entities;
using AutoMapper;

namespace API.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<AuthorCreateDto, Author>().MaxDepth(2);
            CreateMap<AuthorUpdateDto, Author>().MaxDepth(2);
            CreateMap<BookCreateDto, Book>().MaxDepth(1);
        }
    }
}