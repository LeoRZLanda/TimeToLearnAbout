using Dapper;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios{
    public class RepositorioTransaccion : IRepositorioTransacciones{

        private readonly string connectionString;

        public RepositorioTransaccion(IConfiguration configuration){
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(Transaccion transaccion){
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>("Transacciones_Insertar", 
            new {
                transaccion.UsuarioId,
                transaccion.FechaTransaccion,
                transaccion.Monto,
                transaccion.CategoriaId,
                transaccion.CuentaId,
                transaccion.Nota
            },
           commandType: System.Data.CommandType.StoredProcedure);

           transaccion.Id = id;
        }


        public async Task<IEnumerable<Transaccion>> ObtenerPorCuentaId(ObtenerTransaccionesPorCuenta modelo){
            using var connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<Transaccion>
            (@"SELECT t.Id, t.Monto, t.FechaTransacción, c.Nombre as Categoria,
            cu.Nombre as Cuenta, c.TipoTransacciónId
            FROM Transacciones t
            INNER JOIN Categorías c
            ON c.Id = t.CategoriaId
            INNER JOIN Cuentas cu
            ON cu.id = t.CuentaId
            WHERE t.CuentaId = @CuentaId AND t.UsuarioId = @UsuarioId
            AND FechaTransacción BETWEEN @FechaInicio AND @FechaFin",
            modelo
            );
        }


        public async Task Actualizar(Transaccion transaccion, decimal MontoAnterior, int CuentaAnteriorId){
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("Transacciones_Actualizar",
                new {
                    transaccion.Id,
                    transaccion.FechaTransaccion,
                    transaccion.Monto,
                    transaccion.CategoriaId,
                    transaccion.CuentaId,
                    transaccion.Nota,
                    MontoAnterior,
                    CuentaAnteriorId
                }, commandType: System.Data.CommandType.StoredProcedure
            );
        }



        public async Task<Transaccion> ObtenerPorId(int Id, int UsuarioId){
            using var connection = new SqlConnection(connectionString);

            return await connection.QueryFirstOrDefaultAsync<Transaccion>(@"SELECT Transacciones.*, cat.TipoTransacciónId
                                                                            FROM Transacciones
                                                                            INNER JOIN Categorías cat
                                                                            ON cat.Id = Transacciones.CategoriaId
                                                                            WHERE Transacciones.Id = @Id AND
                                                                            Transacciones.UsuarioId = @UsuarioId",
            new {Id, UsuarioId});
        }


        public async Task Borrar(int Id){
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("Transacciones_Borrar", new {Id}, commandType: System.Data.CommandType.StoredProcedure);
        }

    }
}