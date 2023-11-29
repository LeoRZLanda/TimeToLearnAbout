using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Interfaces{
    public interface IRepositorioTransacciones{
        Task Crear(Transaccion transaccion);
        Task Actualizar(Transaccion transaccion, decimal montoAnterior, int CuentaAnteriorId);

        Task<Transaccion> ObtenerPorId(int Id, int UsuarioId);

        Task Borrar(int Id);

        Task<IEnumerable<Transaccion>> ObtenerPorCuentaId(ObtenerTransaccionesPorCuenta modelo);
    }
}