using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace ConsultasWeb.Models
{
    public class DatabaseHelper
    {
        private readonly string _connectionString;

        public DatabaseHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public async Task<DataTable> EjecutarConsultaAsync(string consultaSQL, params SqlParameter[] parametros)
        {
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand(consultaSQL, connection))
                {
                    if (parametros != null)
                        command.Parameters.AddRange(parametros);

                    await connection.OpenAsync();

                    var reader = await command.ExecuteReaderAsync();

                    var dt = new DataTable();
                    dt.Load(reader);

                    return dt;
                }
            }
        }

        // Consulta por edad
        public async Task<DataTable> Consulta1Async(int parametro)
        {
            string sql = "SELECT * FROM Clientes WHERE Edad = @parametro";

            return await EjecutarConsultaAsync(
                sql,
                new SqlParameter("@parametro", parametro)
            );
        }

        // Consulta por categoría
        public async Task<DataTable> Consulta2Async(string parametro)
        {
            string sql = "SELECT * FROM Productos WHERE Categoria = @parametro";

            return await EjecutarConsultaAsync(
                sql,
                new SqlParameter("@parametro", parametro)
            );
        }

        // Consulta por fecha de venta
        public async Task<DataTable> Consulta3Async(DateTime parametro)
        {
            string sql = "SELECT * FROM Ventas WHERE FechaVenta = @parametro";

            return await EjecutarConsultaAsync(
                sql,
                new SqlParameter("@parametro", parametro)
            );
        }
    }
}