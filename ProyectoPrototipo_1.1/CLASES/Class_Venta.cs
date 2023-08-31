using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoPrototipo_1._0
{
    public class Class_Venta
    {
        private Connect connect;

        public Class_Venta(Connect connect)
        {
            this.connect = connect;
        }

        public bool InsertarVenta(DateTime fechaEmision, int idCliente, int idListaProductos, decimal subtotal, decimal iva, decimal descuentoTotalDolares, decimal total, string formaPago, string estado)
        {
            try
            {
                using (SqlConnection connection = connect.RealizarConexion())
                {
                    if (connection == null)
                    {
                        Console.WriteLine("No se pudo establecer la conexión.");
                        return false;
                    }

                    string insertQuery = "INSERT INTO Venta (fechaEmision, idCliente, idListaProductos, subtotal, iva, descuentoTotalDolares, total, formaPago, estado) " +
                        "VALUES (@fechaEmision, @idCliente, @idListaProductos, @subtotal, @iva, @descuentoTotalDolares, @total, @formaPago, @estado)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@fechaEmision", fechaEmision);
                    insertCommand.Parameters.AddWithValue("@idCliente", idCliente);
                    insertCommand.Parameters.AddWithValue("@idListaProductos", idListaProductos);
                    insertCommand.Parameters.AddWithValue("@subtotal", subtotal);
                    insertCommand.Parameters.AddWithValue("@iva", iva);
                    insertCommand.Parameters.AddWithValue("@descuentoTotalDolares", descuentoTotalDolares);
                    insertCommand.Parameters.AddWithValue("@total", total);
                    insertCommand.Parameters.AddWithValue("@formaPago", formaPago);
                    insertCommand.Parameters.AddWithValue("@estado", estado);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    return rowsAffected == 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar venta: " + ex.Message);
                return false;
            }
        }

        public DataTable ConsultarFacturas(string numeroFactura, string cedulaCliente)
        {
            try
            {
                using (SqlConnection connection = connect.RealizarConexion())
                {
                    // Construye la consulta SQL con condiciones opcionales
                    string selectQuery = "SELECT * FROM Factura WHERE 1=1"; // Siempre verdadero para permitir condiciones opcionales

                    if (!string.IsNullOrEmpty(numeroFactura))
                    {
                        selectQuery += " AND NumeroFactura = @numeroFactura";
                    }

                    if (!string.IsNullOrEmpty(cedulaCliente))
                    {
                        selectQuery += " AND CedulaCliente = @cedulaCliente";
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);

                    if (!string.IsNullOrEmpty(numeroFactura))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                    }

                    if (!string.IsNullOrEmpty(cedulaCliente))
                    {
                        dataAdapter.SelectCommand.Parameters.AddWithValue("@cedulaCliente", cedulaCliente);
                    }

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consultar facturas: " + ex.Message);
                return null;
            }
        }

        public bool ActualizarEstadoFactura(int idFactura, string nuevoEstado)
        {
            string connectionString = connect.CadenaConexion; // Reemplaza con tu cadena de conexión.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Inicia una transacción.

                try
                {
                    // Actualizar el estado de la factura
                    string updateEstadoQuery = "UPDATE Factura SET estado = @nuevoEstado WHERE idFactura = @idFactura;";
                    SqlCommand updateEstadoCommand = new SqlCommand(updateEstadoQuery, connection, transaction);

                    updateEstadoCommand.Parameters.AddWithValue("@idFactura", idFactura);
                    updateEstadoCommand.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);

                    int rowsAffected = updateEstadoCommand.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        transaction.Commit(); // Confirmar la transacción, la actualización se guarda en la base de datos.
                        return true; // Actualización exitosa.
                    }
                    else
                    {
                        transaction.Rollback(); // Revertir la transacción si no se actualizó ninguna fila.
                        return false; // La factura con el ID especificado no se encontró.
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // En caso de error, se revierte la transacción.
                    Console.WriteLine("Error al actualizar el estado de la factura: " + ex.Message);
                    return false; // Actualización fallida.
                }
            }
        }

        public bool EliminarFactura(int idFactura)
        {
            string connectionString = connect.CadenaConexion; // Reemplaza con tu cadena de conexión.

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction(); // Inicia una transacción.

                try
                {
                    // Eliminar la factura
                    string deleteFacturaQuery = "DELETE FROM Factura WHERE idFactura = @idFactura;";
                    SqlCommand deleteFacturaCommand = new SqlCommand(deleteFacturaQuery, connection, transaction);

                    deleteFacturaCommand.Parameters.AddWithValue("@idFactura", idFactura);

                    int rowsAffected = deleteFacturaCommand.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        transaction.Commit(); // Confirmar la transacción, la eliminación se guarda en la base de datos.
                        return true; // Eliminación exitosa.
                    }
                    else
                    {
                        transaction.Rollback(); // Revertir la transacción si no se eliminó ninguna fila.
                        return false; // La factura con el ID especificado no se encontró.
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // En caso de error, se revierte la transacción.
                    Console.WriteLine("Error al eliminar la factura: " + ex.Message);
                    return false; // Eliminación fallida.
                }
            }
        }
    }
}
