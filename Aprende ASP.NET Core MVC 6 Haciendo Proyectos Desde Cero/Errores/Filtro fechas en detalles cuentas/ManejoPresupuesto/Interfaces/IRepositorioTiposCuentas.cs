using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Interfaces{
    public interface IRepositorioTiposCuentas{

        Task Actualizar(TipoCuenta tipoCuenta);

        Task Borrar(int Id);

        Task Crear(TipoCuenta tipoCuenta);

        Task<bool> Existe(string nombre, int usuarioId);

        Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId);

        Task<TipoCuenta> ObtenerPorId(int id, int UsuarioId);

        Task Ordenar(IEnumerable<TipoCuenta> tipoCuentasOrdenados);
    }
}