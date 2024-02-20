using EmprestimoLivros.API.Interface;
using EmprestimoLivros.API.Models;
using EmprestimoLivros.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        [HttpGet("selecionarTodos")]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await _clienteRepository.SelecionarTodos());
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarCliente(Cliente cliente)
        {
            _clienteRepository.Incluir(cliente);
            if (await _clienteRepository.SaveAllAsync()) {
                return Ok("Cliente cadastrado com sucesso");
            }

            return BadRequest("Ocorreu um erro ao cadastrar o cliente!");
        }

        [HttpPut]
        public async Task<ActionResult> AlterarCliente(Cliente cliente)
        {
            _clienteRepository.Alterar(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente alterado com sucesso");
            }

            return BadRequest("Ocorreu um erro ao alterar o cliente!");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if(cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            _clienteRepository.Excluir(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente deletado com sucesso");
            }

            return BadRequest("Ocorreu um erro ao deletar o cliente!");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetClientesById(int id)
        {
            var cliente = await _clienteRepository.SelecionarByPk(id);
            if(cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return Ok(cliente);
        }
    }
}
