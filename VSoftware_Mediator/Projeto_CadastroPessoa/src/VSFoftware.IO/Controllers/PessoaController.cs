using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VSoftware.Business.Commands.PessoaCommands;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;
using VSoftware.IO.Models;
using VSoftware.IO.ViewModels;

namespace VSoftware.IO.Controllers
{
	public class PessoaController : BaseController
	{
		private readonly int pageSize = 4;
		private readonly IPessoaRepository _pessoaRepository;
		private readonly IPessoaService _pessoaService;
		private readonly IMapper _mapper;
		private readonly IMediator _mediator;

		public PessoaController(IPessoaRepository pessoaRepository, 
							IMapper mapper, 
							INotificador notificador,
							IPessoaService pessoaService, 
							IMediator mediator) : base(notificador)
		{
			_pessoaRepository = pessoaRepository;
			_mapper = mapper;
			_pessoaService = pessoaService;
			_mediator = mediator;
		}

		[Route("lista-de-pessoas")]
		public async Task<IActionResult> Index(int? pageNumber)
		{
			var lista = _mapper.Map<IEnumerable<PessoaViewModel>>(await _pessoaRepository.ObterTodos());

			return View(PaginatedList<PessoaViewModel>.Create(lista.AsQueryable(), pageNumber ?? 1, pageSize));
		}

		public async Task<IActionResult> Refresh()
		{
			ViewData["FiltroNome"] = "";
			ViewData["FiltroDocumento"] = "";

			var lista = _mapper.Map<IEnumerable<PessoaViewModel>>(await _pessoaRepository.ObterTodos());
			var resultadoRetorno = PaginatedList<PessoaViewModel>.Create(lista.AsQueryable(), 1, pageSize);

			return View("Index", resultadoRetorno);
		}

		[Route("lista-de-pessoas-buscar")]
		public async Task<IActionResult> Buscar(string filtroNome, string filtroDocumento)
		{
			var lista = _mapper.Map<IEnumerable<PessoaViewModel>>(await _pessoaService.Buscar(filtroNome, filtroDocumento));
			var resultadoRetorno = PaginatedList<PessoaViewModel>.Create(lista.AsQueryable(), 1, pageSize);

			ViewData["FiltroNome"] = filtroNome;
			ViewData["FiltroDocumento"] = filtroDocumento;

			return View("Index", resultadoRetorno);
		}

		[Route("dados-da-pessoa/{id:int}")]
		public async Task<IActionResult> Details(int id)
		{
			var pessoaViewModel = _mapper.Map<PessoaViewModel>(await _pessoaRepository.ObterPorId(id));
	
			if (pessoaViewModel == null)
			{
				return NotFound();
			}

			return View(_mapper.Map<PessoaViewModel>(pessoaViewModel));
		}

		[Route("nova-pessoa")]
		public IActionResult Create()
		{
			return View();
		}

		[Route("nova-pessoa")]
		[HttpPost]
		public async Task<IActionResult> Create(PessoaViewModel pessoaViewModel)
		{
			if (!ModelState.IsValid) return View(pessoaViewModel);

			var pessoaCommand = _mapper.Map<PessoaCreateCommand>(pessoaViewModel);

			await _mediator.Send(pessoaCommand);

			if (!OperacaoValida()) return View(pessoaViewModel);

			return RedirectToAction("Index");
		}

		[Route("editar-pessoa/{id:int}")]
		public async Task<IActionResult> Edit(int id)
		{
			var pessoaViewModel = _mapper.Map<PessoaViewModel>(await _pessoaRepository.ObterPorId(id));
			if (pessoaViewModel == null)
				return NotFound();

			return View(_mapper.Map<PessoaViewModel>(pessoaViewModel));
		}

		[Route("editar-pessoa/{id:int}")]
		[HttpPost]
		public async Task<IActionResult> Edit(int id, PessoaViewModel pessoaViewModel)
		{
			if (id != pessoaViewModel.Id) return NotFound();

			if (!ModelState.IsValid)
				return View(pessoaViewModel);

			var pessoaCommand = _mapper.Map<PessoaUpdateCommand>(pessoaViewModel);
			await _mediator.Send(pessoaCommand);

			if (!OperacaoValida()) return View(pessoaViewModel);

			return RedirectToAction("Index");
		}

		[Route("excluir-pessoa/{id:int}")]
		public async Task<IActionResult> Delete(int id)
		{
			var pessoaViewModel = _mapper.Map<PessoaViewModel>(await _pessoaRepository.ObterPorId(id));
			
			if (pessoaViewModel == null) return NotFound();
			
			return View(pessoaViewModel);
		}

		[Route("excluir-pessoa/{id:int}")]
		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var pessoaViewModel = _mapper.Map<PessoaViewModel>(await _pessoaRepository.ObterPorId(id));

			if (pessoaViewModel == null)
				return NotFound();

			var pessoaCommand = new PessoaDeleteCommand() { Id = pessoaViewModel.Id };

			await _mediator.Send(pessoaCommand);

			if (!OperacaoValida()) return View(pessoaViewModel);

			return RedirectToAction("Index");
		}
	}
}