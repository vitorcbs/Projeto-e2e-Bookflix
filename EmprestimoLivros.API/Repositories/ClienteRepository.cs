using EmprestimoLivros.API.Interface;
using EmprestimoLivros.API.Models;

namespace EmprestimoLivros.API.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ControleEmprestimoContext _context;

        public ClienteRepository(ControleEmprestimoContext context)
        {
            _context = context;
        }

        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> SelecionarByPk(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
