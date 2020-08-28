using AutoMapper;
using VSoftware.IO.ViewModels;
using VSoftware.Business.Models;

namespace VSoftware.IO.AutoMapper
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig() { 

			CreateMap<Pessoa, PessoaViewModel>().ReverseMap();
		}
	}
}
