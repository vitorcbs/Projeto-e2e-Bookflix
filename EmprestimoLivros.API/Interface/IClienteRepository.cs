using EmprestimoLivros.API.Models;

namespace EmprestimoLivros.API.Interface
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(Cliente cliente);
        Task<Cliente> SelecionarByPk(int id);
        Task<IEnumerable<Cliente>> SelecionarTodos();
        Task<bool> SaveAllAsync();
    }
}
