using ManejoPresupuesto.Models;

namespace ManejoPresupuesto.Interfaces{
    public interface IRepositorioCuentas{

        Task<IEnumerable<Cuenta>> Buscar(int usuarioId);
        Task Crear(Cuenta cuenta);

        Task<Cuenta> ObtenerPorId(int id, int usuarioId);

        Task Actualizar(CuentaCreacionViewModel cuenta);

        Task Borrar(int id);
    }
}