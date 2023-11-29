using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Interfaces{
    public interface IRepositorioCategorias{

        Task Actualizar(Categoria categoria);

        Task Crear(Categoria categoria);

        Task<IEnumerable<Categoria>> Obtener(int UsuarioId);

        Task<IEnumerable<Categoria>> Obtener(int UsuarioId, TipoTransacción tipoTransacción);

        Task<Categoria> ObtenerPorId(int Id, int UsuarioId);

        Task Borrar(int Id);

    }
}