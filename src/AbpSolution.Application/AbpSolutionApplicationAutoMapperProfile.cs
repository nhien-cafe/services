using AutoMapper;
using AbpSolution.Books;

namespace AbpSolution;

public class AbpSolutionApplicationAutoMapperProfile : Profile
{
    public AbpSolutionApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
