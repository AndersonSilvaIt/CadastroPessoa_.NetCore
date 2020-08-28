using AutoMapper;
using VSoftware.IO.ViewModels;
using VSoftware.Business.Models;
using VSoftware.Business.Commands.PessoaCommands;

namespace VSoftware.IO.AutoMapper
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig() {

			CreateMap<PessoaViewModel, Pessoa>().ReverseMap();
			CreateMap<PessoaCreateCommand, PessoaViewModel>().ReverseMap();
			CreateMap<PessoaUpdateCommand, PessoaViewModel>().ReverseMap();
		}
	}
}
