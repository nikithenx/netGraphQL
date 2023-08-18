using AutoMapper;
using UI.Models;

namespace UI.Mapping
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<AuthorCreate, AuthorCreateDtoInput>().MaxDepth(1);
        }
    }
}