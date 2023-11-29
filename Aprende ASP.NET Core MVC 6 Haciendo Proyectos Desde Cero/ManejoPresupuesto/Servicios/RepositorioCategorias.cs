using Dapper;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Microsoft.Data.SqlClient;

namespace ManejoPresupuesto.Servicios{
    public class RepositorioCategorias : IRepositorioCategorias{

        private readonly string connectionString;

        public RepositorioCategorias(IConfiguration configuration){
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task Crear(Categoria categoria){
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>(@"INSERT INTO Categorías (Nombre, TipoTransacciónId, UsuarioId)
                                                            VALUES (@Nombre, @TipoTransacciónId, @UsuarioId);

                                                            SELECT SCOPE_IDENTITY()"
                                                            , categoria);
            categoria.Id = id;
        }
    
    
        public async Task<IEnumerable<Categoria>> Obtener(int UsuarioId){
            using var connection = new SqlConnection(connectionString);
            var categorias = await connection.QueryAsync<Categoria>("SELECT * FROM Categorías WHERE UsuarioId = @UsuarioId", new {UsuarioId});

            return categorias;
        }
    

        public async Task<IEnumerable<Categoria>> Obtener(int UsuarioId, TipoTransacción tipoTransacciónId){
            using var connection = new SqlConnection(connectionString);
            var categorias = await connection.QueryAsync<Categoria>(@"SELECT * FROM Categorías 
                                                                    WHERE UsuarioId = @UsuarioId 
                                                                    AND TipoTransacciónId = @TipoTransacciónId" , 
                                                                    new {UsuarioId, tipoTransacciónId});

            return categorias;
        }

    
        public async Task<Categoria> ObtenerPorId(int Id, int UsuarioId){
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Categoria>(@"SELECT * FROM Categorías WHERE Id = @Id AND UsuarioId = @UsuarioId", new {Id, UsuarioId});
        }


        public async Task Actualizar(Categoria Categoria){
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"UPDATE Categorías SET Nombre = @Nombre, TipoTransacciónId = @TipoTransacciónId WHERE Id = @Id", Categoria);
        }
    

        public async Task Borrar(int Id){
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"DELETE Categorías WHERE Id = @Id", new {Id});
        }


    }
}